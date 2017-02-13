﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Project.Repository.Common;

namespace Project.Repository
{
    public class DImodul : NinjectModule
    {
        public override void Load()
        {
            Bind<IVehicleMakeRepository>().To<VehicleMakeRepository>();
            Bind<IVehicleModelRepository>().To<VehicleModelRepository>();
            Bind<IGenericRepository>().To<GenericRepository>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
