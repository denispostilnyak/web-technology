using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectStructure.Common.Models.DTO;

namespace ProjectStructure.Common.Models.StructureModels
{
    public class LastProjectCountAndLongerTasks
    {
        public UserDTO User { get; set; }
        public ProjectDTO LastProject { get; set; }
        public int CountTasksPerLastProject { get; set; }
        public int NotFinishedOrCanceledTasks { get; set; }
        public TaskDTO LongestTask { get; set; }
    }
}
