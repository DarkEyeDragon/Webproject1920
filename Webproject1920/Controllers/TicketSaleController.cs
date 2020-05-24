using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.ViewModels;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Service;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Controllers
{
    public class TicketSaleController : Controller
    {
        
        private TicketsaleService _ticketsaleService;
        private GameService _gameService;

        private readonly IMapper _mapper;

        private readonly IOptions<ConnectionStrings> config;

        public TicketSaleController(IMapper mapper, IOptions<ConnectionStrings> config)
        {

         _mapper = mapper;

         this.config = config;
          
            _ticketsaleService = new TicketsaleService(this.config.Value.DefaultConnection.ToString());
            _gameService = new GameService(this.config.Value.DefaultConnection.ToString());

        }

        public async Task<IActionResult> Index()
        {
            
            if (HttpContext.Session.GetInt32("MatchId") == null)
            {

                return Redirect("~/Calendar");
            }
            else
            {
                return View();
            }
        }


        public async Task<IActionResult> TicketSelect()
        {
            var Game = await _gameService.Get(HttpContext.Session.GetInt32("MatchId").GetValueOrDefault());

            GameVM gameServiceList = _mapper.Map<GameVM>(Game);

           

            return View(gameServiceList);          
        }




        [HttpPost]
        public async Task<IActionResult> Index(UserVM naam) 
        {

            var naamT = _mapper.Map<UserVM>(naam);
            HttpContext.Session.SetString("UserName", naamT.Name);


            return Redirect("TicketSelect");
        }

    }
}