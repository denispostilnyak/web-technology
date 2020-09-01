using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectStructure.Common.Models.DTO;
using ProjectStructure.Common.Models.StructureModels;
using ProjectStructure.DAL.Models;
using TaskDAL = ProjectStructure.DAL.Models.Task;

namespace ProjectStructure.BL.Interfaces
{
    public interface IQueriesService
    {
        void AddUser(User user);
        void AddPoject(Project project);
        void AddTeam(Team team);
        void AddTask(TaskDAL task);
        Dictionary<string, int> GetTasksByUser(int id);
        Task<IEnumerable<TaskDTO>> GetTasksByUserNameCondition(int id);
        Task<IEnumerable<TaskDTO>> GetTasksByUserCurrentYear(int id);
        Task<IEnumerable<TaskDTO>> GetUnFinishedUserTasks(int userId);
        IEnumerable<(int, string, IEnumerable<UserDTO>)> GetTeamsOrderTenYears();
        IEnumerable<UserDTO> GetUsersSortedByNameAndTasks();
        LastProjectCountAndLongerTasks GetLastProjectCountAndLongerTasks(int userId);
        IEnumerable<ProjectLongestAndShortestTaskAndUsersAmount> GetProjectLogestAndShortestTaskAndUsersAmount();
    }
}
