using AutoMapper;
using Project.MVC_WebAPI.ViewModels;
using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Project.MVC_WebAPI.Controllers
{
    public class VehicleModelController : ApiController
    {
        private IVehicleModelService vmodelService;
        public VehicleModelController(IVehicleModelService vmService)
        {
            vmodelService = vmService;
        }
        [Route("api/VehicleModel")]
        //[Route("GetAll")]
        [HttpGet]
        public async Task<HttpResponseMessage> GetAllAsync()
        {
            var entity = Mapper.Map<IEnumerable<VehicleModelViewModel>>(await vmodelService.GetAllAsync());
            return Request.CreateResponse(HttpStatusCode.OK, entity);
        }
    }
}
