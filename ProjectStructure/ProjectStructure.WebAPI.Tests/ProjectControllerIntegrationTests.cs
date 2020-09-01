using System;
using System.Net;
using System.Net.Http;
using System.Text;
using FakeItEasy;
using Newtonsoft.Json;
using ProjectStructure.BL.UnitOfWork.Interfaces;
using ProjectStructure.Common.Models.DTO;
using ProjectStructure.DAL.Models;
using ProjectStructure.WebAPI.IntegrationTests;
using Xunit;
using Task = System.Threading.Tasks.Task;

namespace ProjectStructure.WebAPI.Tests
{
    public class ProjectControllerIntegrationTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public ProjectControllerIntegrationTests(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }
        [Fact]
        public async Task AddProject_ThenWaitForCallingRepository()
        {
            var projectDTO = new ProjectDTO
            {
                AuthorId = 1,
                CreatedAt = DateTime.Now,
                Decription = " Some",
                Name = "Third project",
                Deadline = DateTime.Now.AddDays(5),
                TeamId = 1
            };

            string jsonInString = JsonConvert.SerializeObject(projectDTO);
            var response = await _client.PostAsync("api/project",
                new StringContent(jsonInString, Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task AddProject_WhenInvalidParams_ThenStatusCode400() {
            var projectDTO = new ProjectDTO {
                AuthorId = -1,
                CreatedAt = DateTime.Now,
                Decription = " Some",
                Name = "Third project",
                Deadline = DateTime.Now.AddDays(5),
                TeamId = -5
            };

            string jsonInString = JsonConvert.SerializeObject(projectDTO);
            var response = await _client.PostAsync("api/project",
                new StringContent(jsonInString, Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}
