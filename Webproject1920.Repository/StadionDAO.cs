using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Repository
{
    public class StadionDAO
    {
        private readonly VoetbalSQLContext _dbContext;

        public StadionDAO(string dbConn)
        {
            _dbContext = new VoetbalSQLContext(dbConn);
        }

        public async Task<IEnumerable<Stadions>> GetAll()
        {
            return await _dbContext.Stadions
                .Include(s => s.Clubs)
                .ToListAsync();
        }

        public async Task<Stadions> Get(int id)
        {
            return await _dbContext.Stadions.Where(g => g.Id == id)
                .Include(s => s.Clubs)
                .FirstAsync();
        }
    }
}
