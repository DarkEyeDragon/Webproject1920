using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Repository
{
   public class TicketSaleDAO
    {
        private readonly VoetbalSQLContext _dbContext;

        public TicketSaleDAO(string dbConn)
        {
            _dbContext = new VoetbalSQLContext(dbConn);
        }

        public async Task<IEnumerable<Ticketsale>> GetAll()
        {
            return await _dbContext.Ticketsale.ToListAsync();
        }

        public async Task<Ticketsale> Get(int id)
        {
            return await _dbContext.Ticketsale.Where(g => g.Id == id).FirstAsync();
        }
    }
}
