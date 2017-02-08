using Project.DAL.Models;
using Project.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class VehicleMakeDomainModel : IVehicleMakeDomainModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }

        public ICollection<IVehicleModelDomainModel> VehicleModels { get; set; }
    }
}
