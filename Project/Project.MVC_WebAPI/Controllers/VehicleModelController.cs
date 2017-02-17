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
            var entity = Mapper.Map<IEnumerable<VehicleModelViewModel>>(await vmodelService.GetAllAsync());
            return Request.CreateResponse(HttpStatusCode.OK, entity);
        }
        [Route("Get")]
        [HttpGet]
        public async Task<HttpResponseMessage> GetAsync(Guid id)
        {
            var entity = Mapper.Map<VehicleModelViewModel>(await vmodelService.GetAsync(id));
            return Request.CreateResponse(HttpStatusCode.OK, entity);
        }


        [Route("Add")]
        [HttpPost]
        public async Task<HttpResponseMessage> AddAsync(VehicleModelViewModel vmodelView)
        {
            vmodelView.VehicleModelId = Guid.NewGuid();
            var entity = await vmodelService.AddAsync(Mapper.Map<IVehicleModelDomainModel>(vmodelView));
            return Request.CreateResponse(HttpStatusCode.OK, entity);
        }

        [Route("Delete")]
        [HttpDelete]
        public async Task<HttpResponseMessage> DeleteAsync(Guid id)
        {

            var entity = await vmodelService.DeleteAsync(id);
            return Request.CreateResponse(HttpStatusCode.OK, entity);
        }

        [Route("Edit")]
        [HttpPut]
        public async Task<HttpResponseMessage> EditAsync(VehicleModelViewModel vmodelView)
        {
            var entity = await vmodelService.UpdateAsync(Mapper.Map<IVehicleModelDomainModel>(vmodelView));
            return Request.CreateResponse(HttpStatusCode.OK, entity);
        }
    }
}
