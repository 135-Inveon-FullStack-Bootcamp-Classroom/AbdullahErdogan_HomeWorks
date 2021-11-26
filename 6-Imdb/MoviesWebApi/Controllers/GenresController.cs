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
    public class GenresController : ControllerBase
    {
        private ApplicationDbContext _dbContext;
        public GenresController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetGenres()
        {
            var genres = _dbContext.Genre.ToList<Genre>();
            return Ok(genres);
        }
        [HttpPost]
        public IActionResult AddGenre([FromBody] Genre genre)
        {
            _dbContext.Add(genre);
            _dbContext.SaveChanges();
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateGenre(int id,[FromBody] Genre genre)
        {
            Genre _genre = _dbContext.Genre.Where(x => x.GenreId == id).SingleOrDefault();
            _genre.GenreName = genre.GenreName;
            _dbContext.SaveChanges();
            return Ok(genre.GenreName+" updated");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteGenre(int id)
        {
            Genre genre = _dbContext.Genre.Where(x => x.GenreId == id).SingleOrDefault();
            _dbContext.Genre.Remove(genre);
            _dbContext.SaveChanges();
            return Ok("Genre Deleted");
        }
    }
}
