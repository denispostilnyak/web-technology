using System;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.DAL.Models.StructureModels
{
    public class LastProjectCountAndLongerTasks
    {
        public User User { get; set; }
        public Project LastProject { get; set; }
        public int CountTasksPerLastProject { get; set; }
        public int NotFinishedOrCanceledTasks { get; set; }
        public Task LongestTask { get; set; }
    }
}
