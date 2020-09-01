using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ProjectStructure.Common.Models.DTO
{
    public class TeamDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
