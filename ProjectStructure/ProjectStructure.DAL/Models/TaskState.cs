using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectStructure.DAL.Models
{
    public enum TaskState : int {
        Created,
        Started,
        Completed,
        Canceled
    }
}
