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
    // Represents a service for managing players
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository; // Repository for player data
        private readonly ITeamRepository _teamRepository; // Repository for team data
        private readonly ILeagueRepository _leagueRepository; // Repository for league data

        // Constructor that takes three repository instances as parameters
        public PlayerService(IPlayerRepository playerRepository,
                             ITeamRepository teamRepository,
                             ILeagueRepository leagueRepository)
        {
            _playerRepository = playerRepository; // Assign the player repository instance
            _teamRepository = teamRepository; // Assign the team repository instance
            _leagueRepository = leagueRepository; // Assign the league repository instance
        }

        // Retrieves a player by ID
        public Player GetByID(int id)
        {
            return _playerRepository.GetByID(id); // Delegate the retrieval to the player repository
        }

        // Retrieves all players for a given league
        public List<Player> GetForLeague(int leagueID)
        {
            var isValidLeague = _leagueRepository.IsValid(leagueID); // Check if the league is valid

            if (!isValidLeague)
            {
                return new List<Player>(); // Return an empty list if the league is invalid
            }

            List<Player> players = new List<Player>();

            var teams = _teamRepository.GetForLeague(leagueID); // Retrieve all teams for the league

            foreach (var team in teams)
            {
                players.AddRange(_playerRepository.GetForTeam(team.ID)); // Retrieve players for each team
            }

            return players; // Return the list of players
        }
    }
}