using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LINQ.Client.Models
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }
        [JsonProperty("registeredAt")]
        public DateTime RegisteredAt { get; set; }
        [JsonProperty("teamId")]
        public int? TeamId { get; set; }
        public Team Team { get; set; }

        public IEnumerable<Task> Tasks { get; set; }
    }
}
