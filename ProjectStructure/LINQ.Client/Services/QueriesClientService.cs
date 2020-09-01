using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LINQ.Client.Interfaces;
using LINQ.Client.Models;
using LINQ.Client.Models.StructureModels;
using LINQ.Client.Settings;
using Newtonsoft.Json;

namespace ProjectStructure.Client.Services
{
    public class QueriesClientService : IQueriesClientService
    {
        private readonly HttpClient _client;

        public QueriesClientService() {
            _client = new HttpClient { BaseAddress = new Uri(HttpSettings.Host + HttpSettings.ApiEndpoint) };
        }

        async System.Threading.Tasks.Task ResponseStatus(HttpResponseMessage response) {
            if (response.IsSuccessStatusCode) {
                return;
            }

            var messageIfNotSuccess = await response.Content.ReadAsStringAsync();

            throw new Exception(response.StatusCode + messageIfNotSuccess);
        }

        public async Task<Dictionary<string, int>> GetTasksByUser(int id) {

            try
            {
                var url =HttpSettings.QueriesEndpoint + HttpSettings.TasksByUser + id.ToString();

                var response = await _client.GetAsync(url);

                await ResponseStatus(response);

                return JsonConvert.DeserializeObject<Dictionary<string, int>>(await response.Content.ReadAsStringAsync());
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public async Task<IEnumerable<LINQ.Client.Models.Task>> GetTasksByUserNameCondition(int id) {

            try {
                var url = HttpSettings.QueriesEndpoint + HttpSettings.TasksByUserPropertyName + id.ToString();

                var response = await _client.GetAsync(url);

                await ResponseStatus(response);

                return JsonConvert.DeserializeObject<IEnumerable<LINQ.Client.Models.Task>>(await response.Content.ReadAsStringAsync());
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public async Task<IEnumerable<LINQ.Client.Models.Task>> GetTasksByUserCurrentYear(int id) {

            try {
                var url = HttpSettings.QueriesEndpoint + HttpSettings.TasksByUserAndYear + id.ToString();

                var response = await _client.GetAsync(url);

                await ResponseStatus(response);

                return JsonConvert.DeserializeObject<IEnumerable<LINQ.Client.Models.Task>>(await response.Content.ReadAsStringAsync());
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public async Task<IEnumerable<(int, string, List<User>)>> GetTeamsOrderTenYears() {

            try
            {
                var url = HttpSettings.QueriesEndpoint + HttpSettings.TeamsOrderTenYears;

                var response = await _client.GetAsync(url);

                await ResponseStatus(response);

                return JsonConvert.DeserializeObject<IEnumerable<(int, string, List<User>)>>(await response.Content.ReadAsStringAsync());
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public async Task<IEnumerable<User>> GetUsersSortedByNameAndTasks() {

            try {
                var url = HttpSettings.QueriesEndpoint + HttpSettings.UsersSortedByProperties;

                var response = await _client.GetAsync(url);

                await ResponseStatus(response);

                return JsonConvert.DeserializeObject<IEnumerable<User>>(await response.Content.ReadAsStringAsync());
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public async Task<LastProjectCountAndLongerTasks> GetLastProjectCountAndLongerTasks(int userId) {

            try {
                var url = HttpSettings.QueriesEndpoint + HttpSettings.LastProjectCountAndLongerTasks;

                var response = await _client.GetAsync(url);

                await ResponseStatus(response);

                return JsonConvert.DeserializeObject<LastProjectCountAndLongerTasks>(await response.Content.ReadAsStringAsync());
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public async Task<IEnumerable<ProjectLongestAndShortestTaskAndUsersAmount>> GetProjectLogestAndShortestTaskAndUsersAmount() {
            try {
                var url = HttpSettings.QueriesEndpoint + HttpSettings.ProjectLongestAndShortestTaskAndUsersAmount;

                var response = await _client.GetAsync(url);

                await ResponseStatus(response);

                return JsonConvert.DeserializeObject<IEnumerable<ProjectLongestAndShortestTaskAndUsersAmount>>(await response.Content.ReadAsStringAsync());
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
