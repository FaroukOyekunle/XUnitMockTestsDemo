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
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly ITeamRepository _teamRepository;
        private readonly ILeagueRepository _leagueRepository;

        public PlayerService(IPlayerRepository playerRepository,
                                ITeamRepository teamRepository,
                                ILeagueRepository leagueRepository)
        {
            _playerRepository = playerRepository;
            _teamRepository = teamRepository;
            _leagueRepository = leagueRepository;
        }

        public Player GetByID(int id)
        {
            return _playerRepository.GetByID(id);
        }

        public List<Player> GetForLeague(int leagueID)
        {
            var isValidLeague = _leagueRepository.IsValid(leagueID);
            if (!isValidLeague)
            {
                return new List<Player>();
            }   

            List<Player> players = new List<Player>();

            var teams = _teamRepository.GetForLeague(leagueID);

            foreach (var team in teams)
            {
                players.AddRange(_playerRepository.GetForTeam(team.ID));
            }

            return players;
        }
    }
}
