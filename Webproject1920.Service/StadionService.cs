using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Repository;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Service
{
    public class StadionService
    {
        private readonly StadionDAO _stadionDAO;

        public StadionService(string dbConn)
        {
            _stadionDAO = new StadionDAO(dbConn);
        }


        public async Task<IEnumerable<Stadions>> GetAll()
        {
            return await _stadionDAO.GetAll();
        }

        public async Task<Stadions> Get(int id)
        {
            return await _stadionDAO.Get(id);
        }
    }
}
