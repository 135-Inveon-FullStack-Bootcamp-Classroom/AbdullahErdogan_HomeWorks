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
    public class DirectorsController : ControllerBase
    {
        private ApplicationDbContext _dbContext;
        public DirectorsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetDirectors()
        {
            List<Director> directors = _dbContext.Director.ToList<Director>();
            return Ok(directors);
        }
        [HttpPost]
        public IActionResult AddDirector([FromBody] Director director)
        {
            _dbContext.Director.Add(director);
            _dbContext.SaveChanges();
            return Ok(director);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateDirector(int id,[FromBody] Director director)
        {
            Director _director = _dbContext.Director.Where(x => x.DirectorId == id).SingleOrDefault();
            _director.MovieId = director.MovieId;
            _director.DirectorName = director.DirectorName;
            _director.DirectorSurname = director.DirectorSurname;
            _dbContext.SaveChanges();
            return Ok(director.DirectorName + " updated");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDirector(int id)
        {
            Director director = _dbContext.Director.Where(x => x.DirectorId == id).SingleOrDefault();
            _dbContext.Director.Remove(director);
            _dbContext.SaveChanges();
            return Ok("Director Deleted");
        }
    }
}
