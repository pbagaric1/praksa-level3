using Project.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL.Models;
using Project.Model.Common;
using AutoMapper;

namespace Project.Repository
{
    public class VehicleModelRepository : IVehicleModelRepository
    {
        private IGenericRepository genRepo;

        public VehicleModelRepository(IGenericRepository context)
        {
            genRepo = context;
        }

        public async Task<int> AddAsync(IVehicleModelDomainModel entity)
        {
            return await genRepo.AddAsync(Mapper.Map<VehicleModel>(entity));
        }

        public async Task<int> DeleteAllAsync(IEnumerable<IVehicleModelDomainModel> entity)
        {
            return await genRepo.DeleteAllAsync(Mapper.Map<IEnumerable<VehicleModel>>(entity));
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            return await genRepo.DeleteAsync<VehicleModel>(id);
        }

        public async Task<IEnumerable<IVehicleModelDomainModel>> GetAllAsync()
        {
            var response = Mapper.Map<IEnumerable<IVehicleModelDomainModel>>(await genRepo.GetAllAsync<VehicleModel>());
            return response;
        }

        public async Task<int> UpdateAsync(IVehicleModelDomainModel entity)
        {
            return await genRepo.UpdateAsync(Mapper.Map<VehicleModel>(entity));
        }

        public async Task<IVehicleModelDomainModel> GetAsync(Guid id)
        {

            var T_id = Mapper.Map<IVehicleModelDomainModel>(await genRepo.GetAsync<VehicleModel>(id));
            return T_id;
        }
    }
}
