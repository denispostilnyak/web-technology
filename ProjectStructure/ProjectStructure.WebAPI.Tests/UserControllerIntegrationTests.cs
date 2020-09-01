using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using ProjectStructure.Common.Models.DTO;
using Xunit;
using Task = System.Threading.Tasks.Task;

namespace ProjectStructure.WebAPI.IntegrationTests
{
    public class UserControllerIntegrationTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public UserControllerIntegrationTests(CustomWebApplicationFactory<Startup> factory) {
            _client = factory.CreateClient();
        }
        [Fact]
        public async Task DeleteUser_WhenParametersValidAndDeletedSuccess_ThenStatusCode200() {
            var user = new UserDTO {
                Id = 3,
                FirstName = "Serj",
                LastName = "Pos",
                Birthday = DateTime.Parse("28.10.2000"),
                Email = "some",
                RegisteredAt = DateTime.Parse("12.05.2010"),
                TeamId = 1
            };

            string jsonInString = JsonConvert.SerializeObject(user);
            var response = await _client.PostAsync("api/user",
                new StringContent(jsonInString, Encoding.UTF8, "application/json"));

            var deletedUser = await _client.DeleteAsync($"api/user/{user.Id}");
            Assert.Equal(HttpStatusCode.OK, deletedUser.StatusCode);
        }

        [Fact]
        public async Task DeleteUser_WhenUserNotExist_ThenStatusCode404()
        {
            var deletedUser = await _client.DeleteAsync("api/user/-1");
            Assert.Equal(HttpStatusCode.NotFound, deletedUser.StatusCode);
        }
    }
}
