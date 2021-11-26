using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private ApplicationDbContext _dbContext;
        public ActorsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetActors()
        {
            List<Actor> actors = _dbContext.Actor.ToList<Actor>();
            return Ok(actors);
        }
        [HttpPost]
        public IActionResult AddActor([FromBody] Actor actor)
        {
            _dbContext.Actor.Add(actor);
            _dbContext.SaveChanges();
            return Ok(actor);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateActor(int id,[FromBody] Actor actor)
        {
            Actor _actor = _dbContext.Actor.Where(x => x.ActorId == id).SingleOrDefault();
            _actor.MovieId = actor.MovieId;
            _actor.ActorName = actor.ActorName;
            _actor.ActorSurname = actor.ActorSurname;
            _dbContext.SaveChanges();
            return Ok(actor.ActorName + " updated");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteActor(int id)
        {
            Actor actor = _dbContext.Actor.Where(x => x.ActorId == id).SingleOrDefault();
            _dbContext.Actor.Remove(actor);
            _dbContext.SaveChanges();
            return Ok("Actor Deleted");
        }
    }
}
