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
    public class PlayersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PlayersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetTeams()
        {
            var players = await _unitOfWork.PlayerService.GetAllWithPositionsAsync();
            return Ok(players);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetTeam(int id)
        {
            Player player = await _unitOfWork.PlayerService.GetAsync(id);
            if (player == null)
            {
                return BadRequest();
            }
            return Ok(player);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTeam(int id, Player player)
        {
            await _unitOfWork.PlayerService.UpdateAsync(id, player);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Player>> CreateTeam(Player player)
        {
            Player player1 = await _unitOfWork.PlayerService.CreateAsync(player);
            return CreatedAtAction("Get Team", new { id = player1.Id }, player1);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeam(int id)
        {
            await _unitOfWork.PlayerService.DeleteAsync(id);
            return NoContent();
        }
    }
}
