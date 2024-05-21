using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController : ControllerBase
    {
        private readonly IBannerService _bannerService;

        public BannerController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }

        [HttpGet]
        public IActionResult BannerList()
        {
            var values = _bannerService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBanner(Banner banner)
        {
            _bannerService.TInsert(banner);
            return Ok("Banner Başarıyla Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteBanner(int id)
        {
            _bannerService.TDelete(id);
            return Ok("Banner Başarıyla Silindi");
        }

        [HttpPut]
        public IActionResult UpdateteBanner(Banner banner)
        {
            _bannerService.TUpdate(banner);
            return Ok("Banner Başarıyla Güncellendi");
        }

        [HttpGet("GetBanner")]
        public IActionResult GetBanner(int id)
        {
            var values = _bannerService.TGetById(id);
            return Ok(values);
        }
    }
}
