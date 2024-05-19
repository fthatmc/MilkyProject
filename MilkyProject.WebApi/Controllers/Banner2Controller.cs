using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Banner2Controller : ControllerBase
    {
        private readonly IBanner2Service _banner2Service;

        public Banner2Controller(IBanner2Service banner2Service)
        {
            _banner2Service = banner2Service;
        }

        [HttpGet]
        public IActionResult Banner2List()
        {
            var values = _banner2Service.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBanner2(Banner2 banner)
        {
            _banner2Service.TInsert(banner);
            return Ok("Banner Başarıyla Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteBanner2(int id)
        {
            _banner2Service.TDelete(id);
            return Ok("Banner Başarıyla Silindi");
        }

        [HttpPut]
        public IActionResult UpdateteBanner2(Banner2 banner)
        {
            _banner2Service.TUpdate(banner);
            return Ok("Banner Başarıyla Güncellendi");
        }
    }
}
