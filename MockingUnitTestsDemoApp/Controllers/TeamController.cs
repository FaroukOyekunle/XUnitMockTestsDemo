using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockingUnitTestsDemoApp.Implementation.Models;
using MockingUnitTestsDemoApp.Implementation.Services.Interfaces;

namespace MockingUnitTestsDemoApp.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public IActionResult Search()
        {
            // Create a new instance of TeamSearch model
            var teamSearch = new TeamSearch();

            // Return the view with the empty teamSearch model
            return View(teamSearch);
        }

        [HttpPost]
        public IActionResult Search(TeamSearch search)
        {
            // Check if the model state is valid
            if (!ModelState.IsValid)
            {
                // Redirect to the Search action (GET) if the model state is not valid
                return RedirectToAction("Search"); // Assume there is some manner of implementing the PRG Pattern
            }

            // Perform the search using the TeamService and the provided search criteria
            var results = _teamService.Search(search);

            // Check if there are no search results
            if (!results.Any())
            {
                // Redirect to the Search action (GET) if there are no results
                return RedirectToAction("Search");
            }
            else
            {
                // Set the search results in the search model
                search.Results = results;

                // Return the view with the populated search model
                return View(search);
            }
        }
    }
}