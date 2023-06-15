using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockingUnitTestsDemoApp.Implementation.Services.Interfaces;

namespace MockingUnitTestsDemoApp.Controllers
{
    public class LeagueController : Controller
    {
        private readonly ILeagueService _leagueService;

        public LeagueController(ILeagueService leagueService)
        {
            _leagueService = leagueService;
        }

        // Action method for the Index page
        public IActionResult Index()
        {
            // Retrieve all leagues from the league service
            var leagues = _leagueService.GetAll();
            
            // Pass the leagues to the view and return it
            return View(leagues);
        }
    }
}