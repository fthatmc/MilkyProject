using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutImagesController : ControllerBase
    {
        private readonly IAboutImageService _aboutImageService;

        public AboutImagesController(IAboutImageService aboutImageService)
        {
            _aboutImageService = aboutImageService;
        }

        [HttpGet]
        public IActionResult AboutImageList()
        {
            var values = _aboutImageService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAboutImage(AboutImage aboutImage)
        {
            _aboutImageService.TInsert(aboutImage);
            return Ok("Hakkımda Resmi Başarıyla Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteAboutImage(int id)
        {
            _aboutImageService.TDelete(id);
            return Ok("Hakkımda Resmi Başarıyla Silindi");
        }

        [HttpPut]
        public IActionResult UpdateteAboutImage(AboutImage aboutImage)
        {
            _aboutImageService.TUpdate(aboutImage);
            return Ok("Hakkımda Resmi Başarıyla Güncellendi");
        }
    }
}
