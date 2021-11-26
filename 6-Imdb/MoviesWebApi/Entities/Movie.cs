using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApi.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public decimal MovieRating { get; set; }
    }
}
