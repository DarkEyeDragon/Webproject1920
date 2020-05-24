using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Repository;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Service
{
    public class UserTestService
    {
        private readonly UserTestDAO _UserTestServiceDAO;

        public UserTestService(string dbConn)
        {
            _UserTestServiceDAO = new UserTestDAO(dbConn);
        }


        public async Task<IEnumerable<UserTest>> GetAll()
        {
            return await _UserTestServiceDAO.GetAll();
        }

        public async Task<UserTest> Get(int id)
        {
            return await _UserTestServiceDAO.Get(id);
        }
    }
}
