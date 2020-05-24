using System;
using System.Collections.Generic;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities
{
    public partial class Ticketsale
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }
        public int TicketAmount { get; set; }
        public int TicketType { get; set; }

        public virtual Games Game { get; set; }
        public virtual TicketType TicketTypeNavigation { get; set; }
        public virtual UserTest User { get; set; }
    }
}
