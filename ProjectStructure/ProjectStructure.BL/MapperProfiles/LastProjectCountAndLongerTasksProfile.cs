using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ProjectStructure.Common.Models.DTO;
using ProjectStructure.DAL.Models;
using ProjectStructure.DAL.Models.StructureModels;

namespace ProjectStructure.BL.MapperProfiles
{
    public sealed class LastProjectCountAndLongerTasksProfile : Profile
    {
        public LastProjectCountAndLongerTasksProfile()
        {
            CreateMap<LastProjectCountAndLongerTasks, Common.Models.StructureModels.LastProjectCountAndLongerTasks>()
                .ForMember(dest => dest.User,
                    src => src.MapFrom(s => s.User))
                .ForMember(dest => dest.NotFinishedOrCanceledTasks,
                    src => src.MapFrom(s => s.NotFinishedOrCanceledTasks))
                .ForMember(dest => dest.LongestTask,
                    src => src.MapFrom(s => s.LongestTask))
                .ForMember(dest => dest.LastProject,
                    src => src.MapFrom(s => s.LastProject))
                .ForMember(dest => dest.CountTasksPerLastProject,
                    src => src.MapFrom(s => s.CountTasksPerLastProject));
        }
    }
}
