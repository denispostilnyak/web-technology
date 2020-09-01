using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using FakeItEasy;
using ProjectStructure.BL.Interfaces;
using ProjectStructure.BL.Services;
using ProjectStructure.BL.UnitOfWork.Interfaces;
using ProjectStructure.Common.Models.DTO;
using ProjectStructure.DAL.Models;
using Xunit;

namespace ProjectStructure.BL.Tests
{
    public class TeamServiceTests : IDisposable
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProjectStructureContextFake _context;
        private readonly ITeamService _teamService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IRepository<Team> _repository;
        public TeamServiceTests() {
            _context = new ProjectStructureContextFake();
            _context.Database.EnsureCreated();

            _mapper = new Mapper(new MapperConfiguration(cfg => {
                cfg.AddProfile<MapperConfigFake>();
            }));

            _unitOfWork = new UnitOfWork.UnitOfWork(_context);

            _teamService = new TeamService(_unitOfWork, _mapper);

            _userService = new UserService(_unitOfWork, _mapper);
            _repository = A.Fake<IRepository<Team>>();
        }

        public void Dispose() {
        }

        [Fact]
        public void CreateTeamCreateUser_WhenAddUserToTeam_ThenCheckTeam()
        {
            _teamService.CreateTeam(new TeamDTO
            {
                CreatedAt = DateTime.Now,
                Name = "Team 3"
            });

            _userService.CreateUser(new UserDTO
            {
                FirstName = "Vanya",
                LastName = "Zelen",
                Birthday = DateTime.Parse("28.10.2000"),
                Email = "some",
                RegisteredAt = DateTime.Parse("12.05.2010"),
                TeamId = 3
            });
            var currentUser = _userService.GetById(3);

            Assert.Equal(3, currentUser.TeamId);
        }

        [Fact]
        public void CreateTeamCreateUser_WhenAddUserToTeam_ThenRepositoryInvoke() { 
            var team = new TeamDTO {
                CreatedAt = DateTime.Now,
                Name = "Team 3"
            };

            var user = new UserDTO {
                FirstName = "Vanya",
                LastName = "Zelen",
                Birthday = DateTime.Parse("28.10.2000"),
                Email = "some",
                RegisteredAt = DateTime.Parse("12.05.2010"),
                TeamId = 3
            };

            _teamService.CreateTeam(team);
            _userService.CreateUser(user);
            A.CallTo(() => _repository.Create(A<Team>._)).MustHaveHappened();
        }
    }
}
