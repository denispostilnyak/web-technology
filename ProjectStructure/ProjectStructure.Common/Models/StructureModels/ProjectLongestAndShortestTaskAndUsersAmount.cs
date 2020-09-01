using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectStructure.Common.Models.DTO;

namespace ProjectStructure.Common.Models.StructureModels
{
    public class ProjectLongestAndShortestTaskAndUsersAmount
    {
        public ProjectDTO Project { get; set; }
        public TaskDTO LongestTaskByDescription { get; set; }
        public TaskDTO ShortestTaskByName { get; set; }
        public int UsersAmountFilteredByProjectProperties { get; set; }
    }
}
