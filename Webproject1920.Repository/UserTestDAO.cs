using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Repository
{
   public  class UserTestDAO
    {
        private readonly VoetbalSQLContext _dbContext;

        public UserTestDAO(string dbConn)
        {
            _dbContext = new VoetbalSQLContext(dbConn);
        }

        public async Task<IEnumerable<UserTest>> GetAll()
        {
            return await _dbContext.UserTest.ToListAsync();
        }

        public async Task<UserTest> Get(int id)
        {
            return await _dbContext.UserTest.Where(g => g.Id == id).FirstAsync();
        }
    }
}
