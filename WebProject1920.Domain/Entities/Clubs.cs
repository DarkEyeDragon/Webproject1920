using System;
using System.Collections.Generic;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities
{
    public partial class Clubs
    {
        public Clubs()
        {
            GamesAwayTeam = new HashSet<Games>();
            GamesHomeTeam = new HashSet<Games>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int StadionId { get; set; }
        public string Logo { get; set; }
        public int PriceLh { get; set; }
        public int PriceUh { get; set; }
        public int PriceLm { get; set; }
        public int PriceUm { get; set; }

        public virtual Stadions Stadion { get; set; }
        public virtual ICollection<Games> GamesAwayTeam { get; set; }
        public virtual ICollection<Games> GamesHomeTeam { get; set; }
    }
}
