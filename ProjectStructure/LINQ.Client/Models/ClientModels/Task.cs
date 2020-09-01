using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LINQ.Client.Models
{
    public class Task
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("finishedAt")]
        public DateTime FinishedAt { get; set; }
        [JsonProperty("state")]
        public TaskState State { get; set; }
        [JsonProperty("projectId")]
        public int? ProjectId { get; set; }
        public Project Project { get; set; }
        [JsonProperty("perfomerId")]
        public int? PerfomerId { get; set; }
        public User Perfomer { get; set; }
    }
}
