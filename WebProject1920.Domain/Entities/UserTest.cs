using System;
using System.Collections.Generic;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities
{
    public partial class UserTest
    {
        public UserTest()
        {
            Ticketsale = new HashSet<Ticketsale>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Ticketsale> Ticketsale { get; set; }
    }
}
