using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using ProjectStructure.Common.Models.DTO;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.BL.Tests
{
    public class MapperConfigFake : Profile
    {
        public MapperConfigFake()
        {
            CreateMap<IEnumerable<Task>, IEnumerable<TaskDTO>>();
            CreateMap<Task, TaskDTO>();
            CreateMap<TaskDTO, Task>();

            CreateMap<Project, ProjectDTO>();

            CreateMap<Team, TeamDTO>();
            CreateMap<TeamDTO, Team>();

            CreateMap<IEnumerable<User>, IEnumerable<UserDTO>>();
            CreateMap<IEnumerable<UserDTO>, IEnumerable<User>>();
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
