using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProjectStructure.Common.Models.DTO;
using Xunit;

namespace ProjectStructure.WebAPI.IntegrationTests
{
    public class TaskControllerIntegrationTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public TaskControllerIntegrationTests(CustomWebApplicationFactory<Startup> factory) {
            _client = factory.CreateClient();
        }
        [Fact]
        public async Task DeleteTask_WhenParametersValidAndDeletedSuccess_ThenStatusCode200()
        {
            var task = new TaskDTO
            {
                Id = 3,
                CreatedAt = DateTime.Now,
                FinishedAt = DateTime.Now.AddDays(4),
                Description = "Some",
                Name = "Third task",
                PerfomerId = 2,
                ProjectId = 2
            };

            string jsonInString = JsonConvert.SerializeObject(task);
            var response = await _client.PostAsync("api/task",
                new StringContent(jsonInString, Encoding.UTF8, "application/json"));

            var deletedUser = await _client.DeleteAsync($"api/task/{task.Id}");
            Assert.Equal(HttpStatusCode.OK, deletedUser.StatusCode);
        }

        [Fact]
        public async Task DeleteTask_WhenUserNotExist_ThenThrowNotFoundException()
        {
            var deletedUser = await _client.DeleteAsync("api/task/-1");
            Assert.Equal(HttpStatusCode.NotFound, deletedUser.StatusCode);
        }
    }
}
