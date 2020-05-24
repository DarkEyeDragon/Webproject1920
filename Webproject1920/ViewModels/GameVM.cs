using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.ViewModels
{
    public class GameVM
    {
        public int Id { get; set; }
        public Clubs HomeTeam { get; set; }
        public Clubs AwayTeam { get; set; }
        public DateTime Date { get; set; }

        public static implicit operator List<object>(GameVM v)
        {
            throw new NotImplementedException();
        }
    }
}
