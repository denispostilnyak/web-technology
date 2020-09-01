using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ProjectStructure.Common.Models.DTO;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.BL.MapperProfiles
{
    public sealed class ModelsProfile : Profile
    {
        public ModelsProfile() {
            CreateMap<ProjectDTO, Project>();
            CreateMap<Project, ProjectDTO>();

            CreateMap<Task, TaskDTO>();
            CreateMap<TaskDTO, Task>();

            CreateMap<Team, TeamDTO>();
            CreateMap<TeamDTO, Team>();

            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();
        }
    }
}
