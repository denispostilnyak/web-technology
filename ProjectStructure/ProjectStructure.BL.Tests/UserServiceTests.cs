using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using FakeItEasy;
using ProjectStructure.BL.Interfaces;
using ProjectStructure.BL.MapperProfiles;
using ProjectStructure.BL.Services;
using ProjectStructure.BL.UnitOfWork.Interfaces;
using ProjectStructure.Common.Models.DTO;
using ProjectStructure.DAL.Models;
using Xunit;

namespace ProjectStructure.BL.Tests
{
    public class UserServiceTests : IDisposable
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProjectStructureContextFake _context;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IRepository<User> _repository;

        public UserServiceTests()
        {
            _context = new ProjectStructureContextFake();
            _context.Database.EnsureCreated();

            _mapper = new Mapper(new MapperConfiguration(cfg => {
                cfg.AddProfile<MapperConfigFake>();
            }));

            _unitOfWork = new UnitOfWork.UnitOfWork(_context);

            _userService = new UserService(_unitOfWork, _mapper);
            _repository = A.Fake<IRepository<User>>();
        }

        public void Dispose() {
        }

        [Fact]
        public void CreateUser_WhenCreateUser_CheckUsersCount()
        {
            _userService.CreateUser(
                new UserDTO
                {
                    Id = 4,
                    FirstName = "Serj",
                    LastName = "Io",
                    Birthday = DateTime.Parse("28.10.2000"),
                    Email = "some",
                    RegisteredAt = DateTime.Parse("12.05.2010"),
                    TeamId = 1
                });

            var users = _userService.GetById(4);

            Assert.NotNull(users);
        }

        [Fact]
        public void CreateUser_WhenCreateUser_ThenRepositoryInvoked() {
            _userService.CreateUser(
                new UserDTO {
                    Id = 4,
                    FirstName = "Serj",
                    LastName = "Io",
                    Birthday = DateTime.Parse("28.10.2000"),
                    Email = "some",
                    RegisteredAt = DateTime.Parse("12.05.2010"),
                    TeamId = 1
                });
            A.CallTo(() => _repository.Create(A<User>._)).MustHaveHappened();
        }
    }
}
