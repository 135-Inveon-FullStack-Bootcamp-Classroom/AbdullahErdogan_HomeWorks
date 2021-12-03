using FootballManagerApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballManagerApi.ServiceAbstracts
{
    public interface INationalTeamService
    {
        public Task<IEnumerable<NationalTeam>> GetAllAsync();
        public Task<IEnumerable<NationalTeam>> GetAllWithPlayersAsync();
        public Task<NationalTeam> GetAsync(int id);
        public Task UpdateAsync(int id, NationalTeam team);
        public Task<NationalTeam> CreateAsync(NationalTeam team);
        public Task DeleteAsync(int id);
    }
}
