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
            try
            {
                var response = Mapper.Map<IEnumerable<VehicleMakeViewModel>>(await vmakeService.GetAllAsync());
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }

            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Not found.");
            }
        }
        [Route("Get")]
        [HttpGet]
        public async Task<HttpResponseMessage> GetAsync(Guid id)
        {
            try
            {
                var response = Mapper.Map<VehicleMakeViewModel>(await vmakeService.GetAsync(id));
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Not found.");
            }
        }


        [Route("Add")]
        [HttpPost]
        public async Task<HttpResponseMessage> AddAsync(VehicleMakeViewModel vmakeView)
        {
            try {
                vmakeView.Id = Guid.NewGuid();
                var response = await vmakeService.AddAsync(Mapper.Map<IVehicleMakeDomainModel>(vmakeView));
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Can't add vehicle make");
            }
            
        }

        [Route("Delete")]
        [HttpDelete]
        public async Task<HttpResponseMessage> DeleteAsync(Guid id)
        {
            try {
                var response = await vmakeService.DeleteAsync(id);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Not found.");
            }

        }

        [Route("Edit")]
        [HttpPut]
        public async Task<HttpResponseMessage> EditAsync(VehicleMakeViewModel vmakeView)
        {
            try {
                var response = await vmakeService.UpdateAsync(Mapper.Map<IVehicleMakeDomainModel>(vmakeView));
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong input.");
            }

        }

    }
}
