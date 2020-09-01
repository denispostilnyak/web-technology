using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectStructure.BL.UnitOfWork.Interfaces;
using ProjectStructure.DAL.Context;

namespace ProjectStructure.BL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjectStructureContext _context;

        public UnitOfWork(ProjectStructureContext context)
        {
            _context = context;
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public IRepository<T> Set<T>() where T : class
        {
            return new Repository<T>(_context);
        }
    }
}
