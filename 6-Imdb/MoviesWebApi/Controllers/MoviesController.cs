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
    public class MoviesController : ControllerBase
    {
        private ApplicationDbContext _dbContext;
        public MoviesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetMovies()
        {
            List<Movie> movies = _dbContext.Movie.ToList<Movie>();
            return Ok(movies);
        }
        [HttpPost]
        public IActionResult AddMovie([FromBody] Movie movie)
        {
            _dbContext.Add(movie);
            _dbContext.SaveChanges();
            return Ok(movie);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id,[FromBody] Movie movie)
        {
            Movie _movie = _dbContext.Movie.Where(x => x.MovieId == id).SingleOrDefault();
            _movie.GenreId = movie.GenreId;
            _movie.MovieName = movie.MovieName;
            _movie.MovieDescription = movie.MovieDescription;
            _movie.MovieRating = movie.MovieRating;
            _dbContext.SaveChanges();
            return Ok(movie.MovieName + " Updated");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            Movie movie = _dbContext.Movie.Where(x => x.MovieId == id).SingleOrDefault();
            _dbContext.Movie.Remove(movie);
            _dbContext.SaveChanges();
            return Ok("Movie Deleted");
        }
    }
}
