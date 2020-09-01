using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ProjectStructure.Common.Models.DTO
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime FinishedAt { get; set; }
        public TaskStateDTO State { get; set; }
        public int? ProjectId { get; set; }
        public int? PerfomerId { get; set; }
    }
}
