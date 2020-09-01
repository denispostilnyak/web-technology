using System;
using System.Collections.Generic;
using System.Linq;
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
    public class TaskServiceTests : IDisposable
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProjectStructureContextFake _context;
        private readonly ITaskService _taskService;
        private readonly IMapper _mapper;
        private readonly IRepository<Task> _repository;

        public TaskServiceTests() {
            _context = new ProjectStructureContextFake();
            _context.Database.EnsureCreated();

            _mapper = new Mapper(new MapperConfiguration(cfg => {
                cfg.AddProfile<MapperConfigFake>();
            }));

            _unitOfWork = new UnitOfWork.UnitOfWork(_context);

            _taskService = new TaskService(_unitOfWork, _mapper);
            _repository = A.Fake<IRepository<Task>>();
        }

        public void Dispose() {
        }

        [Fact]
        public void ChangeTaskAsCompleted_WhenUpdateTask_ThenUpdatedTask()
        {
            var task = new TaskDTO
            {
                CreatedAt = DateTime.Now,
                FinishedAt = DateTime.Now.AddDays(4),
                Description = "Some",
                Name = "TestStatus task",
                PerfomerId = 2,
                ProjectId = 2
            };

            _taskService.CreateTask(task);

            task.State = TaskStateDTO.Created;
            _taskService.UpdateTask(task);
            var taskFrom = _taskService.GetTaskById(3);

            Assert.Equal(task.State,taskFrom.State );
        }

        [Fact]
        public void ChangeTaskParams_WhenUpdateTask_ThenRepositoryInvoked()
        {
            var task = new TaskDTO {
                CreatedAt = DateTime.Now,
                FinishedAt = DateTime.Now.AddDays(4),
                Description = "Some",
                Name = "TestStatus task",
                PerfomerId = 2,
                ProjectId = 2
            };

            _taskService.CreateTask(task);

            task.State = TaskStateDTO.Completed;
            _taskService.UpdateTask(task);
            
            A.CallTo(() => _repository.Update(A<Task>._)).MustHaveHappened();
        }
    }
}
