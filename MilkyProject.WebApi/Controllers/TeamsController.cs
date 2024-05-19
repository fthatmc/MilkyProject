using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public IActionResult TeamList()
        {
            var values = _teamService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateTeam(Team team)
        {
            _teamService.TInsert(team);
            return Ok("Takım Arkadaşı Başarıyla Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteTeam(int id)
        {
            _teamService.TDelete(id);
            return Ok("Takım Arkadaşı Başarıyla Silindi");
        }

        [HttpPut]
        public IActionResult UpdateteTeam(Team team)
        {
            _teamService.TUpdate(team);
            return Ok("Takım Arkadaşı Başarıyla Güncellendi");
        }
    }
}
