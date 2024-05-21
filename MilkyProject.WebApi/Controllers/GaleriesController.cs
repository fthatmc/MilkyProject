using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaleriesController : ControllerBase
    {
        private readonly IGalleryService _galleryService;

        public GaleriesController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        [HttpGet]
        public IActionResult GalleryList()
        {
            var values = _galleryService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateGallery(Gallery gallery)
        {
            _galleryService.TInsert(gallery);
            return Ok("Galeri Başarıyla Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteGallery(int id)
        {
            _galleryService.TDelete(id);
            return Ok("Galeri Başarıyla Silindi");
        }

        [HttpPut]
        public IActionResult UpdateteGallery(Gallery gallery)
        {
            _galleryService.TUpdate(gallery);
            return Ok("Galeri Başarıyla Güncellendi");
        }

        [HttpGet("GetGallery")]
        public IActionResult GetGallery(int id)
        {
            var values = _galleryService.TGetById(id);
            return Ok(values);
        }
    }
}
