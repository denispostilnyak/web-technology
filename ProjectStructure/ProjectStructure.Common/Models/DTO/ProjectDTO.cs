using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ProjectStructure.Common.Models.DTO
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Deadline { get; set; }
        public int? AuthorId { get; set; }
        public int? TeamId { get; set; }

    }
}
