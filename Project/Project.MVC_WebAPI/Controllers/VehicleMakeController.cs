using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Project.MVC_WebAPI.ViewModels;
using System.Threading.Tasks;

namespace Project.MVC_WebAPI.Controllers
{
    //[Route("api/VehicleMake")]
    public class VehicleMakeController : ApiController
    {
       
        private IVehicleMakeService vmakeService;
        public VehicleMakeController(IVehicleMakeService vmService)
        {
            vmakeService = vmService;
        }
        [Route("api/VehicleMake")]
        //[Route("GetAll")]
        [HttpGet]
        public async Task <HttpResponseMessage> GetAllAsync()
        {
            var entity = Mapper.Map<IEnumerable<VehicleMakeViewModel>>(await vmakeService.GetAllAsync());
            return Request.CreateResponse(HttpStatusCode.OK, entity);
        }
    }
}
