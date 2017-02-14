using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Project.DAL.Models;
using Project.Model;
using Project.Model.Common;
using Project.MVC_WebAPI.ViewModels;

namespace Project.MVC_WebAPI.App_Start
{
    public class AutoMapperConfig
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(config =>
            {


                config.CreateMap<VehicleMake, VehicleMakeDomainModel>().ReverseMap();
                config.CreateMap<VehicleMake, IVehicleMakeDomainModel>().ReverseMap();

                config.CreateMap<VehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();
                config.CreateMap<VehicleMakeDomainModel, IVehicleMakeDomainModel>().ReverseMap();
                config.CreateMap<IVehicleMakeDomainModel, VehicleMakeViewModel>().ReverseMap();


                config.CreateMap<VehicleModel, VehicleModelDomainModel>().ReverseMap();
                config.CreateMap<VehicleModel, IVehicleModelDomainModel>().ReverseMap();

                config.CreateMap<VehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();
                config.CreateMap<VehicleModelDomainModel, IVehicleModelDomainModel>().ReverseMap();
                config.CreateMap<IVehicleModelDomainModel, VehicleModelViewModel>().ReverseMap();
            });
        }
    }
}