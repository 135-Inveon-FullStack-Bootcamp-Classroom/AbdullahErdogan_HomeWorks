using FootballManagerApi.ServiceAbstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballManagerApi.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        public UnitOfWork(ITeamService teamService,IPlayerService playerService,INationalTeamService nationalTeamService)
        {
            this.TeamService = teamService;
            this.PlayerService = playerService;
            this.NationalTeamService = nationalTeamService;
        }
        public ITeamService TeamService { get ; set; }
        public IPlayerService PlayerService{ get; set; }
        public INationalTeamService NationalTeamService { get; set; }
    }
}
