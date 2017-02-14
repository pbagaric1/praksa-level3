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
    public class VehicleModelService : IVehicleModelService
    {
        private IVehicleModelRepository _vModel;

        public VehicleModelService(IVehicleModelRepository vmodel)
        {
            _vModel = vmodel;
        }

        public async Task<int> AddAsync(IVehicleModelDomainModel entity)
        {
            return await _vModel.AddAsync(entity);
        }

        public async Task<int> DeleteAllAsync(IEnumerable<IVehicleModelDomainModel> entity)
        {
            return await _vModel.DeleteAllAsync(entity);
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            return await _vModel.DeleteAsync(id);
        }

        public async Task<IEnumerable<IVehicleModelDomainModel>> GetAllAsync()
        {
            return await _vModel.GetAllAsync();
        }

        public async Task<int> UpdateAsync(IVehicleModelDomainModel entity)
        {
            return await _vModel.UpdateAsync(entity);
        }
    }
}
