using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockingUnitTestsDemoApp.Implementation.Services.Interfaces;

namespace MockingUnitTestsDemoApp.Controllers
{
    public class PlayerController : Controller
    {
        private readonly ILeagueService _leagueService;
        private readonly IPlayerService _playerService;

        public PlayerController(ILeagueService leagueService, IPlayerService playerService)
        {
            _leagueService = leagueService;
            _playerService = playerService;
        }

        // Action method for the Index page
        public IActionResult Index(int id)
        {
            try
            {
                // Get the player by ID from the player service
                var player = _playerService.GetByID(id);
                
                // Pass the player to the view and return it
                return View(player);
            }
            catch (Exception)
            {
                // If an exception occurs, redirect to the Error action of the Home controller
                return RedirectToAction("Error", "Home");
            }
        }

        // Action method for the League page
        public IActionResult League(int id)
        {
            // Check if the league ID is valid using the league service
            if (!_leagueService.IsValid(id))
            {
                // If the league ID is invalid, redirect to the Error action of the Home controller
                return RedirectToAction("Error", "Home");
            }
            
            // Get the players for the league from the player service
            var players = _playerService.GetForLeague(id);
            
            // Pass the players to the view and return it
            return View(players);
        }
    }
