using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectStructure.DAL.Models
{
    public class Task
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MinLength(20)]
        [MaxLength(5000)]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime FinishedAt { get; set; }
        public TaskState State { get; set; }
        public int? ProjectId { get; set; }
        public Project Project { get; set; }
        public int? PerfomerId { get; set; }
        public User Perfomer { get; set; }
    }
}
