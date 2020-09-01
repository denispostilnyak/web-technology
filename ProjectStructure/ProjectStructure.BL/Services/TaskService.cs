using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ProjectStructure.BL.Interfaces;
using ProjectStructure.BL.UnitOfWork.Interfaces;
using ProjectStructure.Common.Models.DTO;
using ProjectStructure.DAL.Context;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.BL.Services
{
    public class TaskService : ITaskService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<DAL.Models.Task> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public TaskService(IUnitOfWork unitOfWork, IMapper mapper) {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.Set<DAL.Models.Task>();
        }
        public async System.Threading.Tasks.Task CreateTask(TaskDTO taskDTO) {
            var task = _mapper.Map<DAL.Models.Task>(taskDTO);

            await _repository.Create(task);
            await _unitOfWork.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteTask(int taskId) {
            await _repository.Delete(taskId);
           await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<TaskDTO>> GetAllTasks() {
            var result = await _repository.Get();
            return _mapper.Map<IEnumerable<TaskDTO>>(result);
        }

        public async Task<TaskDTO>GetTaskById(int id) {
            var result = await _repository.GetById(id);
            return _mapper.Map<TaskDTO>(result);
        }

        public async System.Threading.Tasks.Task<int> UpdateTask(TaskDTO taskDTO) {
            var task = _mapper.Map<DAL.Models.Task>(taskDTO);

            _repository.Update(task);
            await  _unitOfWork.SaveChangesAsync();

            return task.Id;
        }
    }
}
