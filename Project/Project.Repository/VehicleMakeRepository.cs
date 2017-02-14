using Project.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL.Models;
using Project.Model.Common;
using AutoMapper;
using System.Data.Entity;

namespace Project.Repository
{
    public class VehicleMakeRepository : IVehicleMakeRepository
    {
        private IGenericRepository genRepo;

        public VehicleMakeRepository(IGenericRepository context)
        {
            genRepo = context;
        }

        public async Task<int> AddAsync(IVehicleMakeDomainModel entity)
        {
            return await genRepo.AddAsync(Mapper.Map<VehicleMake>(entity));
        }

        public async Task<int> DeleteAllAsync(IEnumerable<IVehicleMakeDomainModel> entity)
        {
            return await genRepo.DeleteAllAsync(Mapper.Map<IEnumerable<VehicleMake>>(entity));
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            return await genRepo.DeleteAsync<IVehicleMakeDomainModel>(id);

        }

        public async Task<IEnumerable<IVehicleMakeDomainModel>> GetAllAsync()
        {
            //var x = await genRepo.GetQueryable<VehicleMake>().Include(s => s.VehicleModels).ToListAsync();
            var response = Mapper.Map<IEnumerable<IVehicleMakeDomainModel>>(await genRepo.GetAllAsync<VehicleMake>());
            return response;
        }

        public async  Task<int> UpdateAsync(IVehicleMakeDomainModel entity)
        {
            return await genRepo.UpdateAsync(Mapper.Map<VehicleMake>(entity));
        }
    }
}
