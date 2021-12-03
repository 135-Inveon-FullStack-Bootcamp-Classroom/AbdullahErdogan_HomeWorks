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
    public class TeamService : ITeamService
    {
        private readonly ApplicationDbContext _context;
        public TeamService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Team> GetAsync(int id)
        {
            Team team = await _context.Teams.FindAsync(id);
            return team;
        }

        public async Task<IEnumerable<Team>> GetAllAsync()
        {
            return await _context.Teams.ToListAsync<Team>();
        }
        public async Task<IEnumerable<Team>> GetAllWithPlayersAsync()
        {
            return await _context.Teams.Include(p => p.Players).ToListAsync<Team>();
        }

        public async Task UpdateAsync(int id, Team team)
        {
            if (id!=team.Id)
            {
                throw new Exception("Id is not found");
            }
            _context.Entry(team).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!TeamExists(id))
                {
                    throw new Exception("Team is not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task<Team> CreateAsync(Team team)
        {
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();
            return team;
        }

        public async Task DeleteAsync(int id)
        {
            Team team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                throw new Exception("Team not found");
            }
            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();
        }
        private bool TeamExists(int id)
        {
            return _context.Teams.Any(x => x.Id == id);
        }
    }
}
