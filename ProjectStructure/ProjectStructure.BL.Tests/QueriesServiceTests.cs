using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using AutoMapper;
using Newtonsoft.Json;
using ProjectStructure.BL.Exceptions;
using ProjectStructure.BL.MapperProfiles;
using ProjectStructure.BL.Services;
using ProjectStructure.Common.Models.DTO;
using ProjectStructure.DAL.Models;
using Xunit;

namespace ProjectStructure.BL.Tests
{
    public class QueriesServiceTests : IDisposable
    {
        private readonly IMapper _mapper;
        private readonly ProjectStructureContextFake _contextFake;
        private readonly QueriesService _queriesService;
        public void Dispose()
        {
        }

        public QueriesServiceTests()
        {
            _mapper = new Mapper (new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperConfigFake>();
                cfg.AddProfile<LastProjectCountAndLongerTasksProfile>();
            }));

            _contextFake = new ProjectStructureContextFake();
            _contextFake.Database.EnsureCreated();

            _queriesService = new QueriesService(_contextFake, _mapper);
        }

        [Fact]
        public void GetTasksByUser_WhenUserNotExist_ThenThrowNotFoundException()
        {
            Assert.Throws<NotFoundException>(() => _queriesService.GetTasksByUser(-1));
        }

        [Fact]
        public void  GetTasksByUser_WhenUserExist_ThenSeeResult() {
            var project = new Project {
                Id = 3,
                AuthorId = 3,
                CreatedAt = DateTime.Now,
                Decription = " Some",
                Name = "Third project",
                ProjectDeadline = DateTime.Now.AddDays(5),
                TeamId = 1

            };

            var user = new User {
                Id = 3,
                FirstName = "Denis",
                LastName = "Pos",
                Birthday = DateTime.Parse("28.10.2000"),
                Email = "some",
                RegisteredAt = DateTime.Parse("12.05.2010"),
                TeamId = 1
            };

            var task = new Task {
                Id = 3,
                CreatedAt = DateTime.Now,
                FinishedAt = DateTime.Now.AddDays(4),
                Description = "Some",
                Name = "Third task",
                PerfomerId = 3,
                ProjectId = 3
            };
            _queriesService.AddTask(task);
            _queriesService.AddUser(user);
            _queriesService.AddPoject(project);

            var result = _queriesService.GetTasksByUser(user.Id);

            Assert.Equal(1, result.FirstOrDefault(t => t.Key == "Third project").Value);
        }

        [Fact]
        public void GetTasksByUserCurrentYear_WhenUserNotExist_ThenThrowNotFoundException() {
            Assert.Throws<NotFoundException>(() => _queriesService.GetTasksByUserCurrentYear(-1));
        }

        [Fact]
        public void GetTasksByUserCurrentYear_WhenUserExist_ThenSeeResult1() {
            var user = new User {
                Id = 3,
                FirstName = "Denis",
                LastName = "Pos",
                Birthday = DateTime.Parse("28.10.2000"),
                Email = "some",
                RegisteredAt = DateTime.Parse("12.05.2010"),
                TeamId = 1
            };

            var task = new Task {
                Id = 3,
                CreatedAt = DateTime.Now,
                FinishedAt = DateTime.Now.AddDays(4),
                Description = "Some",
                Name = "Third task",
                PerfomerId = 3,
                ProjectId = 2
            };
            _queriesService.AddTask(task);
            _queriesService.AddUser(user);

            var tasks = _queriesService.GetTasksByUserCurrentYear(user.Id);

            Assert.Single(tasks);
        }

        [Fact]
        public void GetTasksByUserNameCondition_WhenUserNotExist_ThenThrowNotFoundException() {
            Assert.Throws<NotFoundException>(() => _queriesService.GetTasksByUserNameCondition(-1));
        }

        [Fact]
        public void GetLastProjectCountAndLongerTasks_WhenUserNotExist_ThenThrowNotFoundException() {
            Assert.Throws<NotFoundException>(() => _queriesService.GetTasksByUserNameCondition(-1));
        }
        
        [Fact]
        public void GetTeamsOrderTenYears_WhereUsersFromTeamWithId1OlderTenYears_ThenResultForThisTeam2()
        {
            _queriesService.AddUser(new User
            {
                Id = 1,
                Birthday = DateTime.Parse("12.06.2002"),
                FirstName = "Vasya",
                LastName = "Portyan",
                Email = "some@gmail.com",
                RegisteredAt = DateTime.Parse("26.02.2012"),
                TeamId = 1
            });

            var testingTeam = _queriesService.GetTeamsOrderTenYears()
                .FirstOrDefault(team => team.Item1 == 1);

            Assert.Equal(2, testingTeam.Item3.Count());
        }

        [Fact]
        public void GetUsersSortedByNameAndTasks_WhereAddUserWithCapitalA_ThenAddedUserWillBeFirst() {
            _queriesService.AddUser(new User {
                Id = 1,
                Birthday = DateTime.Parse("12.06.2002"),
                FirstName = "Artur",
                LastName = "Portyan",
                Email = "some@gmail.com",
                RegisteredAt = DateTime.Parse("26.02.2012"),
                TeamId = 2
            });

            var testingUser = _queriesService.GetUsersSortedByNameAndTasks().FirstOrDefault();

            Assert.Equal("Artur", testingUser.FirstName);
        }

        [Fact]
        public void GetProjectLogestAndShortestTaskAndUsersAmount_WhenAddedSomeDataToProject1_ThenWillBeThisDataHere()
        {
            _queriesService.AddTask(
                new Task
            {
                Id = 3,
                CreatedAt = DateTime.Now,
                FinishedAt = DateTime.Now.AddDays(4),
                Description = "This is a description for condition of this method",
                Name = "T",
                PerfomerId = 1,
                ProjectId = 1
            });

            var result = _queriesService.GetProjectLogestAndShortestTaskAndUsersAmount()
                .FirstOrDefault(structs => structs.Project.Id == 1);

            Assert.Equal(3, result.LongestTaskByDescription.Id);
            Assert.Equal(3, result.ShortestTaskByName.Id);
        }

        [Fact]
        public void GetUnFinishedUserTasks_WhenUserExist_ThenSeeResult() {

            var user = new User {
                Id = 3,
                FirstName = "Denis",
                LastName = "Pos",
                Birthday = DateTime.Parse("28.10.2000"),
                Email = "some",
                RegisteredAt = DateTime.Parse("12.05.2010"),
                TeamId = 1
            };

            var task = new Task {
                Id = 3,
                CreatedAt = DateTime.Now,
                FinishedAt = DateTime.Now.AddDays(4),
                Description = "Some",
                Name = "Third task",
                PerfomerId = 3,
                ProjectId = 2
            };

            _queriesService.AddUser(user);
            _queriesService.AddTask(task);

            var content = _queriesService.GetUnFinishedUserTasks(user.Id);

            Assert.Single(content);
        }

        [Fact]
        public void GetUnFinishedUserTasks_WhenUserNotExist_ThenThrowNotFoundException()
        {
            Assert.Throws<NotFoundException>(()=>_queriesService.GetUnFinishedUserTasks(-1));
        }
    }
}
