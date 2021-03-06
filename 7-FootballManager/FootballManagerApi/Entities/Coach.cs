using FootballManagerApi.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballManagerApi.Entities
{
    public class Coach : Person, IEntity
    {
        public int Id { get ; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public ICollection<Tactic> FavoriteTactics { get; set; }
    }
}
