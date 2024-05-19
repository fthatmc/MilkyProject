using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.DtoLayer.TeamSocialMediaDtos;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamSocialMediasController : ControllerBase
    {
        private readonly ITeamSocialMediaService _teamSocialMediaService;

        public TeamSocialMediasController(ITeamSocialMediaService teamSocialMediaService)
        {
            _teamSocialMediaService = teamSocialMediaService;
        }

        [HttpGet]
        public IActionResult TeamSocialMediaList()
        {
            var values = _teamSocialMediaService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateTeamSocialMedia(TeamSocialMedia socialMedia)
        {
            _teamSocialMediaService.TInsert(socialMedia);
            return Ok("Takım Sosyal Medya Başarıyla Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteTeamSocialMedia(int id)
        {
            _teamSocialMediaService.TDelete(id);
            return Ok("Takım Sosyal Medya Başarıyla Silindi");
        }

        [HttpPut]
        public IActionResult UpdateTeamSocialMedia(TeamSocialMedia socialMedia)
        {
            _teamSocialMediaService.TUpdate(socialMedia);
            return Ok("Takım Sosyal Medya Başarıyla Güncellendi");
        }

        [HttpGet("TeamSocialMediaByTeamId/{id}")]
        public IActionResult TeamSocialMediaByTeamId(int id)
        {
            var values = _teamSocialMediaService.TGetTeamSocialMediaByTeamId(id);
            return Ok(values);
        }

    }
}
