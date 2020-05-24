using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Repository
{
    public class GameDAO
    {

        private readonly VoetbalSQLContext _dbContext;

        public GameDAO(string dbConn)
        {
            _dbContext = new VoetbalSQLContext(dbConn);
        }

        public async Task<IEnumerable<Games>> GetAll()
        {
            return await _dbContext.Games
                .Include(g => g.HomeTeam)
                .Include(g => g.HomeTeam.Stadion)
                .Include(g => g.AwayTeam)
                .Include(g => g.AwayTeam.Stadion)
                .ToListAsync();
        }

        public async Task<IEnumerable<Games>> GetAllSorted()
        {
            return await _dbContext.Games
                .Include(g => g.HomeTeam)
                .Include(g => g.HomeTeam.Stadion)
                .Include(g => g.AwayTeam)
                .Include(g => g.AwayTeam.Stadion)
                .OrderBy(g => g.Date)
                .ToListAsync();
        }

        public async Task<Games> Get(int id)
        {
            return await _dbContext.Games
                .Where(g => g.Id == id)
                .Include(g => g.HomeTeam)
                .Include(g => g.HomeTeam.Stadion)
                .Include(g => g.AwayTeam)
                .Include(g => g.AwayTeam.Stadion)
                .FirstAsync();
        }



        public async Task<IEnumerable<Games>> GetAllFromPloeg(int clubId)
        {
            //Return all games where the team with the matching id plays or visits
            return await _dbContext.Games
                .Where(g => g.HomeTeamId == clubId || g.AwayTeamId == clubId)
                .Include(g => g.HomeTeam)
                .Include(g => g.HomeTeam.Stadion)
                .Include(g => g.AwayTeam)
                .Include(g => g.AwayTeam.Stadion)
                .ToListAsync();
        }
    }
}
