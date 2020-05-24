using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Repository
{
  
        public class ClubDAO
        {

            private readonly VoetbalSQLContext _dbContext;

            public ClubDAO(string dbConn)
            {
                _dbContext = new VoetbalSQLContext(dbConn);
            }
          
            public async Task<IEnumerable<Clubs>> GetAll()
            {
                return await _dbContext.Clubs
                .Include(c => c.Stadion)
                .Include(c => c.GamesAwayTeam)
                .Include(c => c.GamesHomeTeam)
                .ToListAsync();
            }

            public async Task<Clubs> Get(int id)
            {
                return await _dbContext.Clubs.Where(g => g.Id == id)
                .Include(c => c.Stadion)
                .Include(c => c.GamesAwayTeam)
                .Include(c => c.GamesHomeTeam)
                .FirstAsync();
            }

        }
    }

