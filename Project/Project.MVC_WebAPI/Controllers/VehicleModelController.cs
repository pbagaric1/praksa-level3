using AutoMapper;
using Project.Model.Common;
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
    [RoutePrefix("api/VehicleModel")]
    public class VehicleModelController : ApiController
    {
        private IVehicleModelService vmodelService;
        public VehicleModelController(IVehicleModelService vmService)
        {
            vmodelService = vmService;
        }
        [Route("GetAll")]
        [HttpGet]
        public async Task<HttpResponseMessage> GetAllAsync()
        {
            try
            {
                var entity = Mapper.Map<IEnumerable<VehicleModelViewModel>>(await vmodelService.GetAllAsync());
                return Request.CreateResponse(HttpStatusCode.OK, entity);
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
                var entity = Mapper.Map<VehicleModelViewModel>(await vmodelService.GetAsync(id));
                return Request.CreateResponse(HttpStatusCode.OK, entity);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Not found.");
            }
        }


        [Route("Add")]
        [HttpPost]
        public async Task<HttpResponseMessage> AddAsync(VehicleModelViewModel vmodelView)
        {
            try {
                vmodelView.VehicleModelId = Guid.NewGuid();
                var entity = await vmodelService.AddAsync(Mapper.Map<IVehicleModelDomainModel>(vmodelView));
                return Request.CreateResponse(HttpStatusCode.OK, entity);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Can't add vehicle model.");
            }

        }

        [Route("Delete")]
        [HttpDelete]
        public async Task<HttpResponseMessage> DeleteAsync(Guid id)
        {
            try
            {
                var entity = await vmodelService.DeleteAsync(id);
                return Request.CreateResponse(HttpStatusCode.OK, entity);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Not found.");
            }
        }

        [Route("Edit")]
        [HttpPut]
        public async Task<HttpResponseMessage> EditAsync(VehicleModelViewModel vmodelView)
        {
            try
            {
                var toBeUpdated = Mapper.Map<VehicleModelViewModel>(await vmodelService.GetAsync(vmodelView.VehicleModelId));
                toBeUpdated.Name = vmodelView.Name;
                toBeUpdated.Abrv = vmodelView.Abrv;
                var response = await vmodelService.UpdateAsync(Mapper.Map<IVehicleModelDomainModel>(toBeUpdated));
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong input.");
            }
        }
    }
}
