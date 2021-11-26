using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApi.Entities
{
    public class Actor
    {
        public int ActorId { get; set; }
        public int MovieId { get; set; }
        public string ActorName { get; set; }
        public string ActorSurname { get; set; }
    }
}
