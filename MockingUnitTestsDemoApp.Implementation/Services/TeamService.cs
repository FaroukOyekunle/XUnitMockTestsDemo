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
    // Represents a service for managing teams
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository; // Repository for team data
        private readonly ILeagueRepository _leagueRepository; // Repository for league data

        // Constructor that takes two repository instances as parameters
        public TeamService(ITeamRepository teamRepository,
                           ILeagueRepository leagueRepository)
        {
            _teamRepository = teamRepository; // Assign the team repository instance
            _leagueRepository = leagueRepository; // Assign the league repository instance
        }

        // Searches for teams based on search criteria
        public List<Team> Search(TeamSearch search)
        {
            var isValidLeague = _leagueRepository.IsValid(search.LeagueID); // Check if the league is valid

            if (!isValidLeague)
            {
                return new List<Team>(); // Return an empty list if the league is invalid
            }

            var allTeams = _teamRepository.GetForLeague(search.LeagueID); // Retrieve all teams for the league

            // Filter teams based on founding date and direction
            if (search.Direction == Enums.SearchDateDirection.OlderThan)
            {
                return allTeams.Where(x => x.FoundingDate <= search.FoundingDate).ToList();
            }
            else
            {
                return allTeams.Where(x => x.FoundingDate >= search.FoundingDate).ToList();
            }
        }
    }
}