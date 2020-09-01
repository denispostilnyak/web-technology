using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ProjectStructure.BL.Interfaces;
using ProjectStructure.BL.UnitOfWork.Interfaces;
using ProjectStructure.Common.Models.DTO;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.BL.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Project> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public ProjectService(IMapper mapper, IUnitOfWork unitOfWork) {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.Set<Project>();
        }
        public async System.Threading.Tasks.Task CreateProject(ProjectDTO projectDTO) {
            var project = _mapper.Map<Project>(projectDTO);
            if (project.AuthorId < 0 || project.TeamId < 0)
            {
                throw new Exception();
            }
            await _repository.Create(project);
            await _unitOfWork.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteProject(int projectId) {
            await _repository.Delete(projectId);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProjectDTO>> GetAllProjects() {
            var result = await _repository.Get();
            return _mapper.Map<IEnumerable<ProjectDTO>>(result);
        }

        public async System.Threading.Tasks.Task UpdateProject(ProjectDTO projectDTO) {
            var project = _mapper.Map<Project>(projectDTO);

            _repository.Update(project);
           await _unitOfWork.SaveChangesAsync();
        }
    }
}
