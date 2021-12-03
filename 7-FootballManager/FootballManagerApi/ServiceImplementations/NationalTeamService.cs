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
    public class NationalTeamService : INationalTeamService
    {
        private readonly ApplicationDbContext _context;
        public NationalTeamService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<NationalTeam> GetAsync(int id)
        {
            NationalTeam team = await _context.NationalTeams.FindAsync(id);
            return team;
        }

        public async Task<IEnumerable<NationalTeam>> GetAllAsync()
        {
            return await _context.NationalTeams.ToListAsync<NationalTeam>();
        }
        public async Task<IEnumerable<NationalTeam>> GetAllWithPlayersAsync()
        {
            return await _context.NationalTeams.ToListAsync<NationalTeam>();
        }

        public async Task UpdateAsync(int id, NationalTeam team)
        {
            if (id != team.Id)
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

        public async Task<NationalTeam> CreateAsync(NationalTeam team)
        {
            _context.NationalTeams.Add(team);
            await _context.SaveChangesAsync();
            return team;
        }

        public async Task DeleteAsync(int id)
        {
            NationalTeam team = await _context.NationalTeams.FindAsync(id);
            if (team == null)
            {
                throw new Exception("Team not found");
            }
            _context.NationalTeams.Remove(team);
            await _context.SaveChangesAsync();
        }
        private bool TeamExists(int id)
        {
            return _context.NationalTeams.Any(x => x.Id == id);
        }
    }
}
