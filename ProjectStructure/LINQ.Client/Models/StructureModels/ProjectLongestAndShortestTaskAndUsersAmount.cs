using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Client.Models.StructureModels
{
    public class ProjectLongestAndShortestTaskAndUsersAmount
    {
        public Project Project { get; set; }
        public Task LongestTaskByDescription { get; set; }
        public Task ShortestTaskByName { get; set; }
        public int UsersAmountFilteredByProjectProperties { get; set; }
    }
}
