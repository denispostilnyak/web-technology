using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectStructure.DAL.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(5000)]
        public string Decription { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ProjectDeadline { get; set; }
        public int? AuthorId { get; set; }
        public User Author { get; set; }
        public int? TeamId { get; set; }
        public Team Team { get; set; }
        public bool IsActive { get; set; }

        public IEnumerable<Task> Tasks { get; set; }
    }
}
