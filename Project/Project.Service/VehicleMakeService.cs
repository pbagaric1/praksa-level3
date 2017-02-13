using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model.Common;
using Project.Repository.Common;

namespace Project.Service
{
    public class VehicleMakeService : IVehicleMakeService
    {
        //private IUnitOfWork _uow;
        private IVehicleMakeRepository _vMake;

        public VehicleMakeService(IVehicleMakeRepository vmake)
        {
            _vMake = vmake;
        }

        public async Task<int> AddAsync(IVehicleMakeDomainModel entity)
        {
            return await _vMake.AddAsync(entity);
        }

        public async Task<int> DeleteAllAsync(IEnumerable<IVehicleMakeDomainModel> entity)
        {
            return await _vMake.DeleteAllAsync(entity);
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            return await _vMake.DeleteAsync(id);
        }

        public async Task<IEnumerable<IVehicleMakeDomainModel>> GetAllAsync()
        {
            return await _vMake.GetAllAsync();
        }

        public async Task<int> UpdateAsync(IVehicleMakeDomainModel entity)
        {
            return await _vMake.UpdateAsync(entity);
        }
    }
}
