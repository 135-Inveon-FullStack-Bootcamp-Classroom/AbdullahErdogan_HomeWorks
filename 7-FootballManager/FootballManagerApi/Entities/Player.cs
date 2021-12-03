using FootballManagerApi.EntityBase;
using System;
using System.Collections.Generic;


namespace FootballManagerApi.Entities
{
    public class Player:Person,IEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public ICollection<Position> Positions { get; set; }
    }
}
