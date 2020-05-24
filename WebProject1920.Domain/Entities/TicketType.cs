using System;
using System.Collections.Generic;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities
{
    public partial class TicketType
    {
        public TicketType()
        {
            Ticketsale = new HashSet<Ticketsale>();
        }

        public int Id { get; set; }
        public string TicketType1 { get; set; }

        public virtual ICollection<Ticketsale> Ticketsale { get; set; }
    }
}
