using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectStructure.Common.Models.DTO;

namespace ProjectStructure.BL.Interfaces
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskDTO>> GetAllTasks();

        Task CreateTask(TaskDTO task); 
        Task<TaskDTO> GetTaskById(int id);
        Task<int> UpdateTask(TaskDTO task);
        Task DeleteTask(int taskId);
    }
}
