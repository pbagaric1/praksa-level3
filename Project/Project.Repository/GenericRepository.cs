using Project.DAL.Interfaces;
using Project.Repository.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly IVehicleContext _context;
        private readonly DbSet<T> _dbset;

        public GenericRepository(IVehicleContext context)
        {
            _context = context;
        }
        public async Task <IEnumerable<T>> GetAllAsync<T>() where T: class
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<int> AddAsync<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync<T>(T entity) where T : class
        {
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAllAsync<T>(IEnumerable<T> entity) where T : class
        {
            foreach (var ent in entity)
            {
                _context.Set<T>().Remove(ent);
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync<T>(T entity) where T : class
        {
            _context.Entry(entity).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }


        
    }
}
