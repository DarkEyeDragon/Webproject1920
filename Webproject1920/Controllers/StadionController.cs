using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.Service;
using webproject1920_Bruelemans_Darwyn_Tack_Joshua.ViewModels;

namespace webproject1920_Bruelemans_Darwyn_Tack_Joshua.Controllers
{
    public class StadionController : Controller
    {

        private readonly IOptions<ConnectionStrings> config;
        private readonly IMapper _mapper;


        public StadionController(IMapper mapper, IOptions<ConnectionStrings> config)
        {
            _mapper = mapper;

            this.config = config;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? stadionId)
        {
            if (!stadionId.HasValue)
            {
                return NotFound();
            }
            StadionService stadionService = new StadionService(config.Value.DefaultConnection.ToString());
            var stadion = await stadionService.Get(stadionId.Value);

            StadionVM stadionVM = _mapper.Map<StadionVM>(stadion);
            return View(stadionVM);
           
        }
    }
}