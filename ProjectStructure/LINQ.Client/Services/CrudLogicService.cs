using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LINQ.Client.Interfaces;
using LINQ.Client.Models;
using LINQ.Client.Models.StructureModels;
using LINQ.Client.Settings;
using Newtonsoft.Json;
using ProjectStructure.Client.Interfaces;

namespace LINQ.Client.Services
{
    public class CrudLogicService : ICrudLogicService
    {
        private readonly HttpClient _client;

        public CrudLogicService() {
            _client = new HttpClient { BaseAddress = new Uri(HttpSettings.Host + HttpSettings.ApiEndpoint) };
        }

        async System.Threading.Tasks.Task ResponseStatus(HttpResponseMessage response) {
            if (response.IsSuccessStatusCode) {
                return;
            }

            var messageIfNotSuccess = await response.Content.ReadAsStringAsync();

            throw new Exception(response.StatusCode + messageIfNotSuccess);
        }

        private string GetUrl(Type type) {
            string url = "";
            if (type == typeof(Project)) {
                url = HttpSettings.ProjectsEndpoint;
            }

            if (type == typeof(Team)) {
                url = HttpSettings.TeamsEndpoint;
            }

            if (type == typeof(User)) {
                url = HttpSettings.UsersEndpoint;
            }

            if (type == typeof(Models.Task)) {
                url = HttpSettings.TasksEndpoint;
            }

            return url;
        }

        public async System.Threading.Tasks.Task<IEnumerable<T>> Get<T>() {
            try {
                var url = GetUrl(typeof(T));

                var response = await _client.GetAsync(url);

                await ResponseStatus(response);

                return JsonConvert.DeserializeObject<IEnumerable<T>>(await response.Content.ReadAsStringAsync());
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public async System.Threading.Tasks.Task Create<T>(T model) {
            var url = GetUrl(typeof(T));

            var inputJson = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync(url, inputJson);
            await ResponseStatus(response);
        }

        public async System.Threading.Tasks.Task<int> Update<T>(T model) {
            var url = GetUrl(typeof(T));

            var inputJson = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            var response = await _client.PutAsync(url, inputJson);
            await ResponseStatus(response);

            return JsonConvert.DeserializeObject<int>(await response.Content.ReadAsStringAsync());
        }

        public async System.Threading.Tasks.Task Delete<T>(int id) {
            var url = GetUrl(typeof(T)) + "/" + id.ToString();

            var response = await _client.DeleteAsync(url);
            await ResponseStatus(response);
        }
    }
}
