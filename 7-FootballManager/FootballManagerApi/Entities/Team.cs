using FootballManagerApi.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballManagerApi.Entities
{
    public class Team:IEntity
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public ICollection<Team> Players { get; set; }
        public int Id { get; set ; }
        public DateTime CreateDate { get ; set ; }
        public DateTime UpdateDate { get; set ; }
    }
}
