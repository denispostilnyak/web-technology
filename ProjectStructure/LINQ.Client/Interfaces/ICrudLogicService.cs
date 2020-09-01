using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStructure.Client.Interfaces
{
    interface ICrudLogicService
    {
        Task Create<T>(T model);
        Task<IEnumerable<T>> Get<T>();
        Task<int> Update<T>(T model);
        Task Delete<T>(int id);
    }
}
