using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Repository;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Service
{
    public class ClubService
    {
        private readonly ClubDAO _clubDAO;

        public ClubService(string dbConn)
        {
            _clubDAO = new ClubDAO(dbConn);
        }


        public async Task<IEnumerable<Clubs>> GetAll()
        {
            return await _clubDAO.GetAll();
        }

        public async Task<Clubs> Get(int id)
        {
            return await _clubDAO.Get(id);
        }
    }
}
