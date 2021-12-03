using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballManagerApi.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public Team Team { get; set; }
        public NationalTeam NationalTeam { get; set; }
    }
}
