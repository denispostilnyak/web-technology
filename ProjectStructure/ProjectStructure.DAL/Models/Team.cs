using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectStructure.DAL.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public DateTime CreatedAtDate { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}
