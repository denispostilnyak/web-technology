using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectStructure.Common.Models.DTO;

namespace ProjectStructure.BL.Interfaces
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectDTO>> GetAllProjects();

        Task CreateProject(ProjectDTO project);
        Task UpdateProject(ProjectDTO project);
        Task DeleteProject(int projectId);
    }
}
