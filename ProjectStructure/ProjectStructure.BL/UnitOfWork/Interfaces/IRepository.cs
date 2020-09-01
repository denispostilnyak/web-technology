using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStructure.BL.UnitOfWork.Interfaces
{
    public interface IRepository<T> where T: class
    {
        Task<IEnumerable<T>> Get();
        Task<T> GetById(int id);
        Task Create(T entity);
        void Update(T entity);
        Task Delete(object id);
        void Delete(T entity);
    }
}
