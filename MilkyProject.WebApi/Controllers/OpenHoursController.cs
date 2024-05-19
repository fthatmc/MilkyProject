using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenHoursController : ControllerBase
    {
        private readonly IOpenHoursService _openHoursService;

        public OpenHoursController(IOpenHoursService openHoursService)
        {
            _openHoursService = openHoursService;
        }
        
        [HttpGet]
        public IActionResult OpenHoursList()
        {
            var values = _openHoursService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateOpenHours(OpenHours openHours)
        {
            _openHoursService.TInsert(openHours);
            return Ok("OpenHours Başarıyla Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteOpenHours(int id)
        {
            _openHoursService.TDelete(id);
            return Ok("OpenHours Başarıyla Silindi");
        }

        [HttpPut]
        public IActionResult UpdateteOpenHours(OpenHours openHours)
        {
            _openHoursService.TUpdate(openHours);
            return Ok("OpenHours Başarıyla Güncellendi");
        }

    }
}
