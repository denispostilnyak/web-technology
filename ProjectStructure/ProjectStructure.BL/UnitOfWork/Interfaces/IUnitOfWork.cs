using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStructure.BL.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<T> Set<T>() where T : class;
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
