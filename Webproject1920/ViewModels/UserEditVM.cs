using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.ViewModels
{
    public class UserEditVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
