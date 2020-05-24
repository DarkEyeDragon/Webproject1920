using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Repository;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Service
{
    public class TicketsaleService
    {
        private readonly TicketSaleDAO _ticketsaleDAO;

        public TicketsaleService(string dbConn)
        {
            _ticketsaleDAO = new TicketSaleDAO(dbConn);
        }


        public async Task<IEnumerable<Ticketsale>> GetAll()
        {
            return await _ticketsaleDAO.GetAll();
        }

        public async Task<Ticketsale> Get(int id)
        {
            return await _ticketsaleDAO.Get(id);
        }
    }
}
