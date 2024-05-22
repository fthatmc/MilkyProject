using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServicesController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _serviceService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            _serviceService.TInsert(service);
            return Ok("Service Başarıyla Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            _serviceService.TDelete(id);
            return Ok("Service Başarıyla Silindi");
        }

        [HttpPut]
        public IActionResult UpdateteService(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok("OpenHours Başarıyla Güncellendi");
        }
        [HttpGet("GetService")]
        public IActionResult GetService(int id)
        {
            var values = _serviceService.TGetById(id);
            return Ok(values);
        }
    }
}
