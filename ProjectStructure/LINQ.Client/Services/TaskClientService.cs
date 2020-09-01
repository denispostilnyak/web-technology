using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LINQ.Client.Services;
using LINQ.Client.Settings;
using ProjectStructure.Client.Interfaces;

namespace ProjectStructure.Client.Services
{
    public class TaskClientService
    {
        private readonly ICrudLogicService _crudLogicService;
        private static System.Timers.Timer _aTimer;

        public TaskClientService()
        {
            _crudLogicService = new CrudLogicService();
            _aTimer = new System.Timers.Timer();
        }
        public async Task<int> MarkRandomTaskWithDelay(int interval)
        {
            var taskCompletionSource = new TaskCompletionSource<int>();
            LINQ.Client.Models.Task task = new LINQ.Client.Models.Task();
            int taskId = 0;
            _aTimer.Start();
            _aTimer.Elapsed += async (o, e) =>
            {
                try {
                    task = await GetRandomTask();
                } catch {
                    Console.WriteLine("There is all completed tasks");
                    taskCompletionSource.TrySetException(new Exception());
                }
                task.State = LINQ.Client.Models.TaskState.Completed;
                
                taskId = await _crudLogicService.Update<LINQ.Client.Models.Task>(task);
                Console.WriteLine($"task id is {taskId}");
                taskCompletionSource.TrySetResult(taskId);
            };

            _aTimer.Interval = interval; 
            _aTimer.AutoReset = false;
            _aTimer.Enabled = true;
            return await taskCompletionSource.Task;
        }


        private async Task<LINQ.Client.Models.Task> GetRandomTask()
        {
            var tasks = await _crudLogicService.Get<LINQ.Client.Models.Task>();
            tasks = tasks.Where(task => task.State != LINQ.Client.Models.TaskState.Completed);
            if (!tasks.Any())
            {
                throw new Exception();
            }
            var randomNumb = new Random();
            var randomIndex = randomNumb.Next(tasks.Count());

            return  tasks.ElementAtOrDefault(randomIndex);
        }
    }
}
