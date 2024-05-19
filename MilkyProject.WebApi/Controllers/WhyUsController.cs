using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhyUsController : ControllerBase
    {
        private readonly IWhyUsService _whyUsService;

        public WhyUsController(IWhyUsService whyUsService)
        {
            _whyUsService = whyUsService;
        }

        [HttpGet]
        public IActionResult WhyUslList()
        {
            var values = _whyUsService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateWhyUs(WhyUs whyUs)
        {
            _whyUsService.TInsert(whyUs);
            return Ok("Neden Biz Başarıyla Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteWhyUs(int id)
        {
            _whyUsService.TDelete(id);
            return Ok("Neden Biz Başarıyla Silindi");
        }

        [HttpPut]
        public IActionResult UpdateteWhyUs(WhyUs whyUs)
        {
            _whyUsService.TUpdate(whyUs);
            return Ok("Neden Biz Başarıyla Güncellendi");
        }
    }
}
