using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Repository;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Service
{
    public class GameService
    {
        private readonly GameDAO _gameDAO;

        public GameService(string dbConn)
        {
            _gameDAO = new GameDAO( dbConn);
        }


        public async Task<IEnumerable<Games>> GetAll()
        {
            return await _gameDAO.GetAll();
        }

        public async Task<IEnumerable<Games>> GetAllSorted()
        {
            return await _gameDAO.GetAllSorted();
        }

        public async Task<Games> Get(int id)
        {
            return await _gameDAO.Get(id);
        }

        public async Task<IEnumerable<Games>> GetAllFromPloeg(int clubId)
        {
            return await _gameDAO.GetAllFromPloeg(clubId);
        }


    }
}
