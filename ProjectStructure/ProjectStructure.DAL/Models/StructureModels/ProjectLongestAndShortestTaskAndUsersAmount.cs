using System;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.DAL.Models;

namespace ProjectStructure.DAL.Models.StructureModels
{
    public class ProjectLongestAndShortestTaskAndUsersAmount
    {
        public Project Project { get; set; }
        public Task LongestTaskByDescription { get; set; }
        public Task ShortestTaskByName { get; set; }
        public int UsersAmountFilteredByProjectProperties { get; set; }
    }
}
