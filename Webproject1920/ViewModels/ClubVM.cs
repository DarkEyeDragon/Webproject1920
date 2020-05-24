using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.ViewModels
{
    public class ClubVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Stadions StadionId { get; set; }
        public string Logo { get; set; }
        public int PriceLh { get; set; }
        public int PriceUh { get; set; }
        public int PriceLm { get; set; }
        public string PriceUm { get; set; }

    }
}
