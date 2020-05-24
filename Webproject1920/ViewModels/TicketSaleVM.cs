using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.ViewModels
{
    public class TicketSaleVM
    {
        public int Id { get; set; }
        public UserTest UserId { get; set; }
        public Games GameId { get; set; }
        public int TicketAmount { get; set; }
        public TicketType TicketType { get; set; }
    }
}
