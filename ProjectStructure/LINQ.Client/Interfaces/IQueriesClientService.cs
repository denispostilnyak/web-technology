using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LINQ.Client.Models;
using LINQ.Client.Models.StructureModels;


namespace LINQ.Client.Interfaces
{
    interface IQueriesClientService
    {
        Task<Dictionary<string, int>> GetTasksByUser(int id);
        Task<IEnumerable<Models.Task>> GetTasksByUserNameCondition(int id);
        Task<IEnumerable<Models.Task>> GetTasksByUserCurrentYear(int id);
        Task<IEnumerable<(int, string, List<User>)>> GetTeamsOrderTenYears();
        Task<IEnumerable<User>> GetUsersSortedByNameAndTasks();
        Task<LastProjectCountAndLongerTasks> GetLastProjectCountAndLongerTasks(int userId);
        Task<IEnumerable<ProjectLongestAndShortestTaskAndUsersAmount>> GetProjectLogestAndShortestTaskAndUsersAmount();
    }
}
