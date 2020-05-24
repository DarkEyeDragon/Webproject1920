using System;
using System.Collections.Generic;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities
{
    public partial class Games
    {
        public Games()
        {
            Ticketsale = new HashSet<Ticketsale>();
        }

        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public DateTime Date { get; set; }

        public virtual Clubs AwayTeam { get; set; }
        public virtual Clubs HomeTeam { get; set; }
        public virtual ICollection<Ticketsale> Ticketsale { get; set; }
    }
}
