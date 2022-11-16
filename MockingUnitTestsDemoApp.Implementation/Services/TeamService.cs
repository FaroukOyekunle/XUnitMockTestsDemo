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
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;
        private readonly ILeagueRepository _leagueRepository;

        public TeamService(ITeamRepository teamRepository,
                           ILeagueRepository leagueRepository)
        {
            _teamRepository = teamRepository;
            _leagueRepository = leagueRepository;
        }

        public List<Team> Search(TeamSearch search)
        {
            //If we are searching for an invalid or unknown League...

            var isValidLeague = _leagueRepository.IsValid(search.LeagueID);
            if (!isValidLeague)
            {
                return new List<Team>();  //Return an empty list.
            }
                

            //Otherwise get all teams in the specified league...

            var allTeams = _teamRepository.GetForLeague(search.LeagueID);

            //... and filter them by the specified Founding Date and Direction.

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
