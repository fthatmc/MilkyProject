using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationsController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public IActionResult LocationList()
        {
            var values = _locationService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateLocation(Location location)
        {
            _locationService.TInsert(location);
            return Ok("Lokasyon Başarıyla Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteLocation(int id)
        {
            _locationService.TDelete(id);
            return Ok("Lokasyon Başarıyla Silindi");
        }

        [HttpPut]
        public IActionResult UpdateteLocation(Location location)
        {
            _locationService.TUpdate(location);
            return Ok("Lokasyon Başarıyla Güncellendi");
        }
    }
}
