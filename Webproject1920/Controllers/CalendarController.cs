using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.ViewModels;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Service;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.Rendering;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Entities;
using Microsoft.AspNetCore.Http;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Controllers
{
    public class CalendarController : Controller
    {
    
        private GameService gameService;
        private ClubService clubService;

        private readonly IMapper _mapper;

        private readonly IOptions<ConnectionStrings> config;

        public CalendarController(IMapper mapper, IOptions<ConnectionStrings> config)
        {
            _mapper = mapper;

            this.config = config;

            gameService = new GameService(this.config.Value.DefaultConnection.ToString());
            clubService = new ClubService(this.config.Value.DefaultConnection.ToString());

        }

        public async Task<IActionResult> Index()
        {
            var list = await gameService.GetAllSorted();

            List<CalendarVM> calendarVM = _mapper.Map<List<CalendarVM>>(list);
            ViewBag.lstGames = new SelectList(await clubService.GetAll(), "Id", "Name");
            return View(calendarVM);
        }

        [HttpPost]
        public async Task<IActionResult> Index(int? Id)
        {
            if (!Id.HasValue)
            {
                return await Index();
            }
            var listGames = await gameService.GetAllFromPloeg(Id.Value);
            List<CalendarVM> calendarVM = _mapper.Map<List<CalendarVM>>(listGames);
            ViewBag.lstGames = new SelectList(await clubService.GetAll(), "Id", "Name");
            return View(calendarVM);
        }


        [HttpGet]
        public async Task<IActionResult> startSale(int ID)
        {

            if (ID != 0)
            {
                HttpContext.Session.SetInt32("MatchId", ID);

                return Redirect("../../TicketSale/Index");
            }
            else
                return Redirect("~/Calendar");


        }
    }
}