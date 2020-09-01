using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectStructure.Common.Models.DTO
{
    public enum TaskStateDTO : int {
        Created,
        Started,
        Completed,
        Canceled
    }
}
