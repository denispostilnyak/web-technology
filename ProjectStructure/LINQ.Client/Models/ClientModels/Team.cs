using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LINQ.Client.Models
{
    public class Team
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}
