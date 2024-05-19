using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutServicesController : ControllerBase
    {
        private readonly IAboutServiceService _aboutServiceService;

        public AboutServicesController(IAboutServiceService aboutServiceService)
        {
            _aboutServiceService = aboutServiceService;
        }

        [HttpGet]
        public IActionResult AboutServiceList()
        {
            var values = _aboutServiceService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAboutService(AboutService about)
        {
            _aboutServiceService.TInsert(about);
            return Ok("Hakkımda Servis Başarıyla Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteAboutService(int id)
        {
            _aboutServiceService.TDelete(id);
            return Ok("Hakkımda Servis Başarıyla Silindi");
        }

        [HttpPut]
        public IActionResult UpdateteAboutService(AboutService about)
        {
            _aboutServiceService.TUpdate(about);
            return Ok("Hakkımda Servis Başarıyla Güncellendi");
        }
    }
}
