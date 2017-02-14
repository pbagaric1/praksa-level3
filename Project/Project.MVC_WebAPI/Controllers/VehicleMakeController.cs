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
using Project.Model.Common;

namespace Project.MVC_WebAPI.Controllers
{
    [RoutePrefix("api/VehicleMake")]
    public class VehicleMakeController : ApiController
    {
       
        private IVehicleMakeService vmakeService;
        public VehicleMakeController(IVehicleMakeService vmService)
        {
            vmakeService = vmService;
        }
        [Route("GetAll")]
        [HttpGet]
        public async Task <HttpResponseMessage> GetAllAsync()
        {
            var entity = Mapper.Map<IEnumerable<VehicleMakeViewModel>>(await vmakeService.GetAllAsync());
            return Request.CreateResponse(HttpStatusCode.OK, entity);
        }

        //[Route("Add")]
        //[HttpPost]
        //public async Task<HttpResponseMessage> AddAsync(VehicleMakeViewModel vmakeView)
        //{
        //    var entity = Mapper.Map(await vmakeService.AddAsync(vmakeView));
        //    return Request.CreateResponse(HttpStatusCode.OK, entity);
        //}

        [Route("Delete")]
        [HttpDelete]
        public async Task<HttpResponseMessage> DeleteAsync(Guid id)
        {

            Mapper.Map<VehicleMakeViewModel>(await vmakeService.DeleteAsync(id));
            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}
