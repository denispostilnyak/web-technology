using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectStructure.BL.Exceptions;
using ProjectStructure.BL.UnitOfWork.Interfaces;
using ProjectStructure.DAL.Context;

namespace ProjectStructure.BL.UnitOfWork
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ProjectStructureContext _context;
        public Repository(ProjectStructureContext context)
        {
            _context = context;
        }
        public virtual async Task Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public virtual async Task Delete(object id)
        {
            T entity = await _context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                throw new NotFoundException(typeof(T).ToString());
            }
            Delete(entity);
        }

        public void Delete(T entity)
        {

            var dbSet = _context.Set<T>();

            if(_context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }

        public virtual async Task<IEnumerable<T>> Get()
        {
            IQueryable<T> query = _context.Set<T>();
            if (!await query.AnyAsync())
            {
                throw new ArgumentException();
            }
            return await query.ToListAsync();
        }

        public virtual async Task<T> GetById(int id) {
            return await _context.Set<T>().FindAsync(id);
        }

        public virtual void Update(T entity)
        {
            if (entity == null)
            {
                throw new Exception();
            }

            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
