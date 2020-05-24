using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Models;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Service;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IOptions<ConnectionStrings> config)
        {
           
        }
        public IActionResult Index()
        {
         
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
