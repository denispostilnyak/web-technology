using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Client.Models
{
    public enum TaskState : int {
        Created,
        Started,
        Completed,
        Canceled
    }
}
