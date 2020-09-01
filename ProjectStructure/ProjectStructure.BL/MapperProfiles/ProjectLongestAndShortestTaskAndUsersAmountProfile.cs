using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using ProjectStructure.DAL.Models.StructureModels;

namespace ProjectStructure.BL.MapperProfiles
{
    public sealed class ProjectLongestAndShortestTaskAndUsersAmountProfile : Profile
    {
        public ProjectLongestAndShortestTaskAndUsersAmountProfile()
        {
            CreateMap<IEnumerable<ProjectLongestAndShortestTaskAndUsersAmount>, IEnumerable<Common.Models.StructureModels.ProjectLongestAndShortestTaskAndUsersAmount>>()
                .ForMember(dest=>dest.Select(d=>d.LongestTaskByDescription).FirstOrDefault(),
            src=>src.MapFrom(s=>s.Select(l=>l.LongestTaskByDescription).FirstOrDefault()))
                .ForMember(dest => dest.Select(d => d.Project).FirstOrDefault(),
                    src => src.MapFrom(s => s.Select(l => l.Project).FirstOrDefault()))
                .ForMember(dest => dest.Select(d => d.ShortestTaskByName).FirstOrDefault(),
                    src => src.MapFrom(s => s.Select(l => l.ShortestTaskByName).FirstOrDefault()))
                .ForMember(dest => dest.Select(d => d.UsersAmountFilteredByProjectProperties).FirstOrDefault(),
                    src => src.MapFrom(s => s.Select(l => l.UsersAmountFilteredByProjectProperties).FirstOrDefault()));
        }
    }
}
