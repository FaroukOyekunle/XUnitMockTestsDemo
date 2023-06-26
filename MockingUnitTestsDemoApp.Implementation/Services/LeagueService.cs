using MockingUnitTestsDemoApp.Implementation.Models;
using MockingUnitTestsDemoApp.Implementation.Repositories.Interfaces;
using MockingUnitTestsDemoApp.Implementation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingUnitTestsDemoApp.Implementation.Services
{
    // Represents a service for managing leagues
    public class LeagueService : ILeagueService
    {
        private readonly ILeagueRepository _leagueRepository; // Repository for league data

        // Constructor that takes an ILeagueRepository instance as a parameter
        public LeagueService(ILeagueRepository leagueRepository)
        {
            _leagueRepository = leagueRepository; // Assign the repository instance to the private field
        }

        // Checks if a league with the specified ID is valid
        public bool IsValid(int id)
        {
            return _leagueRepository.IsValid(id); // Delegate the validation to the repository
        }

        // Retrieves a list of all leagues
        public List<League> GetAll()
        {
            return _leagueRepository.GetAll(); // Retrieve all leagues from the repository
        }
    }
}