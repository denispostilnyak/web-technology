using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LINQ.Client.Models
{
    public class Project
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Decription { get; set; }
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("deadline")]
        public DateTime Deadline { get; set; }
        [JsonProperty("authorId")]
        public int? AuthorId { get; set; }
        public User Author { get; set; }
        [JsonProperty("teamId")]
        public int? TeamId { get; set; }
        public Team Team { get; set; }

        public IEnumerable<Task> Tasks { get; set; }
    }
}
