﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.ViewModels
{
    public class StadionVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Seats { get; set; }
        public int SeatsLh { get; set; }
        public int SeatsLa { get; set; }
        public int SeatsLme { get; set; }
        public int SeatsLmw { get; set; }
        public int SeatsUh { get; set; }
        public int SeatsUa { get; set; }
        public int SeatsUme { get; set; }
        public int SeatsUmw { get; set; }
    }
}
