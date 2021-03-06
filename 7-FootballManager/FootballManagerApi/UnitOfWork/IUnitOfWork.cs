using FootballManagerApi.ServiceAbstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballManagerApi.UnitOfWork
{
    public interface IUnitOfWork
    {
        public ITeamService TeamService { get; set; }
        public IPlayerService PlayerService { get; set; }
        public INationalTeamService NationalTeamService { get; set; }
    }
}
