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
    public class TeamControllerIntegrationTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public TeamControllerIntegrationTests(CustomWebApplicationFactory<Startup> factory) {
            _client = factory.CreateClient();
        }
        [Fact]
        public async Task CreateCommand_WhenCreatedCommand_ThenStatusCode200()
        {
            var team = new TeamDTO
            {
                Id = 3,
                CreatedAt = DateTime.Now,
                Name = "Team 3"
            };

            string jsonInString = JsonConvert.SerializeObject(team);
            var response = await _client.PostAsync("api/team",
                new StringContent(jsonInString, Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task CreateCommand_WhenInvalidParams_ThenStatusCode400() {
            var team = new TeamDTO {
                Id = -2,
                CreatedAt = DateTime.Now,
                Name = "Team 3"
            };

            string jsonInString = JsonConvert.SerializeObject(team);
            var response = await _client.PostAsync("api/team",
                new StringContent(jsonInString, Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}
