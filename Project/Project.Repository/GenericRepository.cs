using Project.DAL.Interfaces;
using Project.Repository.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository
{
    public class GenericRepository: IGenericRepository
    {
        private readonly IVehicleContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public GenericRepository(IVehicleContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public IQueryable<T> GetQueryable<T>() where T : class
        {
            return _context.Set<T>();
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

        public async Task<int> DeleteAsync<T>(Guid id) where T : class
        {
            T entity = await _context.Set<T>().FindAsync(id);
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
            _context.Set<T>().AddOrUpdate(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<T> GetAsync<T>(Guid id) where T: class
        {

            var T_id = await _context.Set<T>().FindAsync(id);
            return  T_id;
        }
    }
}
