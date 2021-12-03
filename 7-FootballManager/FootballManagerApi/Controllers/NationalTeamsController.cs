using FootballManagerApi.Entities;
using FootballManagerApi.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalTeamsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public NationalTeamsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NationalTeam>>> GetTeams()
        {
            var teams = await _unitOfWork.NationalTeamService.GetAllWithPlayersAsync();
            return Ok(teams);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NationalTeam>> GetTeam(int id)
        {
            NationalTeam team = await _unitOfWork.NationalTeamService.GetAsync(id);
            if (team == null)
            {
                return BadRequest();
            }
            return Ok(team);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTeam(int id, NationalTeam team)
        {
            await _unitOfWork.NationalTeamService.UpdateAsync(id, team);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<NationalTeam>> CreateTeam(NationalTeam team)
        {
            NationalTeam team1 = await _unitOfWork.NationalTeamService.CreateAsync(team);
            return CreatedAtAction("Get Team", new { id = team1.Id }, team1);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeam(int id)
        {
            await _unitOfWork.NationalTeamService.DeleteAsync(id);
            return NoContent();
        }
    }
}
