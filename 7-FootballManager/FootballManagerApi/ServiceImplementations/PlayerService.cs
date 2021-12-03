using FootballManagerApi.Data;
using FootballManagerApi.Entities;
using FootballManagerApi.ServiceAbstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballManagerApi.ServiceImplementations
{
    public class PlayerService : IPlayerService
    {
        private readonly ApplicationDbContext _context;
        public PlayerService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Player> CreateAsync(Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();
            return player;
        }

        public async Task DeleteAsync(int id)
        {
            Player player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                throw new Exception("Team not found");
            }
            _context.Players.Remove(player);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Player>> GetAllAsync()
        {
            return await _context.Players.ToListAsync<Player>();
        }

        public async Task<IEnumerable<Player>> GetAllWithPositionsAsync()
        {
            return await _context.Players.Include(p => p.Positions).ToListAsync<Player>();
        }

        public async Task<Player> GetAsync(int id)
        {
            Player player = await _context.Players.FindAsync(id);
            return player;
        }

        public async Task UpdateAsync(int id, Player player)
        {
            if (id != player.Id)
            {
                throw new Exception("Id is not found");
            }
            _context.Entry(player).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!PlayerExists(id))
                {
                    throw new Exception("Team is not found");
                }
                else
                {
                    throw;
                }
            }
        }
        private bool PlayerExists(int id)
        {
            return _context.Players.Any(x => x.Id == id);
        }
    }
}
