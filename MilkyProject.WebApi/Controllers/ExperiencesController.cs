using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperiencesController : ControllerBase
    {
        private readonly IExperienceService _experienceService;

        public ExperiencesController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        [HttpGet]
        public IActionResult ExperienceList()
        {
            var values = _experienceService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            _experienceService.TInsert(experience);
            return Ok("Deneyim Başarıyla Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteExperience(int id)
        {
            _experienceService.TDelete(id);
            return Ok("Deneyim Başarıyla Silindi");
        }

        [HttpPut]
        public IActionResult UpdateteExperience(Experience experience)
        {
            _experienceService.TUpdate(experience);
            return Ok("Deneyim Başarıyla Güncellendi");
        }
    }
}
