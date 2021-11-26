using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApi.Entities
{
    public class Director
    {
        public int DirectorId { get; set; }
        public int MovieId { get; set; }
        public string DirectorName { get; set; }
        public string DirectorSurname { get; set; }
    }
}
