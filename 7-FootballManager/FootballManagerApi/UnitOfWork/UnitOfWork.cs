using FootballManagerApi.ServiceAbstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballManagerApi.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        public UnitOfWork(ITeamService teamService)
        {
            this.TeamService = teamService;
        }
        public ITeamService TeamService { get ; set; }
    }
}
