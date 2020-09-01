using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ProjectStructure.Common.Models.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime RegisteredAt { get; set; }
        public int? TeamId { get; set; }
    }
}
