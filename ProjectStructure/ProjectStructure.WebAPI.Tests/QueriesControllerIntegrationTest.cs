using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProjectStructure.Common.Models.DTO;
using Xunit;

namespace ProjectStructure.WebAPI.IntegrationTests
{
    public class QueriesControllerIntegrationTest : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public QueriesControllerIntegrationTest(CustomWebApplicationFactory<Startup> factory) {
            _client = factory.CreateClient();
        }
        [Fact]
        public async Task GetTasksByUser_WhenUserExist_ThenSeeResult()
        {
            var project = new ProjectDTO
            {
                Id = 3,
                AuthorId = 3,
                CreatedAt = DateTime.Now,
                Decription = " Some",
                Name = "Third project",
                Deadline = DateTime.Now.AddDays(5),
                TeamId = 1

            };

            var user = new UserDTO
            {
                Id = 3,
                FirstName = "Denis",
                LastName = "Pos",
                Birthday = DateTime.Parse("28.10.2000"),
                Email = "some",
                RegisteredAt = DateTime.Parse("12.05.2010"),
                TeamId = 1
            };

            var task = new TaskDTO
            {
                Id = 3,
                CreatedAt = DateTime.Now,
                FinishedAt = DateTime.Now.AddDays(4),
                Description = "Some",
                Name = "Third task",
                PerfomerId = 3,
                ProjectId = 3
            };
            string jsonInStringProject = JsonConvert.SerializeObject(project);
            var projectResponse = await _client.PostAsync("api/project",
                new StringContent(jsonInStringProject, Encoding.UTF8, "application/json"));

            string jsonInStringUser = JsonConvert.SerializeObject(user);
            var userResponse = await _client.PostAsync("api/user",
                new StringContent(jsonInStringUser, Encoding.UTF8, "application/json"));

            string jsonInStringTask = JsonConvert.SerializeObject(task);
            var taskResponse = await _client.PostAsync("api/task",
                new StringContent(jsonInStringTask, Encoding.UTF8, "application/json"));

            var getResponse = await _client.GetAsync($"api/queries/tasksByUser/{user.Id}");
            var content =
                JsonConvert.DeserializeObject<Dictionary<string, int>>(await getResponse.Content.ReadAsStringAsync());

            Assert.Equal(1, content.FirstOrDefault(t => t.Key == "Third project").Value);
        }

        [Fact]
        public async Task GetTasksByUser_WhenUserNotExist_ThenThrowNotFoundException()
        {
            var getResponse = await _client.GetAsync("api/queries/tasksByUser/-1");

            Assert.Equal(HttpStatusCode.NotFound, getResponse.StatusCode);
        }

        [Fact]
        public async Task GetUnFinishedUserTasks_WhenUserExist_ThenSeeResult() {

            var user = new UserDTO {
                Id = 3,
                FirstName = "Denis",
                LastName = "Pos",
                Birthday = DateTime.Parse("28.10.2000"),
                Email = "some",
                RegisteredAt = DateTime.Parse("12.05.2010"),
                TeamId = 1
            };

            var task = new TaskDTO {
                Id = 3,
                CreatedAt = DateTime.Now,
                FinishedAt = DateTime.Now.AddDays(4),
                Description = "Some",
                Name = "Third task",
                PerfomerId = 3,
                ProjectId = 2
            };

            string jsonInStringUser = JsonConvert.SerializeObject(user);
            var userResponse = await _client.PostAsync("api/user",
                new StringContent(jsonInStringUser, Encoding.UTF8, "application/json"));

            string jsonInStringTask = JsonConvert.SerializeObject(task);
            var taskResponse = await _client.PostAsync("api/task",
                new StringContent(jsonInStringTask, Encoding.UTF8, "application/json"));

            var getResponse = await _client.GetAsync($"api/queries/unFinishedUserTasks/{user.Id}");
            var content =
                JsonConvert.DeserializeObject<IEnumerable<TaskDTO>>(await getResponse.Content.ReadAsStringAsync());

            Assert.Single(content);
        }

        [Fact]
        public async Task GetUnFinishedUserTasks_WhenUserNotExist_ThenThrowNotFoundException() {
            var getResponse = await _client.GetAsync("api/queries/unFinishedUserTasks/-1");

            Assert.Equal(HttpStatusCode.NotFound, getResponse.StatusCode);
        }
    }
}
