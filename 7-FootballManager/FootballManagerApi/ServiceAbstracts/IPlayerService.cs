using FootballManagerApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManagerApi.ServiceAbstracts
{
    public interface IPlayerService
    {
        public Task<IEnumerable<Player>> GetAllAsync();
        public Task<IEnumerable<Player>> GetAllWithPositionsAsync();
        public Task<Player> GetAsync(int id);
        public Task UpdateAsync(int id, Player player);
        public Task<Player> CreateAsync(Player player);
        public Task DeleteAsync(int id);
    }
}
