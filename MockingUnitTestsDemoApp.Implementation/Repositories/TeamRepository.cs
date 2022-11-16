using MockingUnitTestsDemoApp.Implementation.Models;
using MockingUnitTestsDemoApp.Implementation.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingUnitTestsDemoApp.Implementation.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        public Team GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Team> GetForLeague(int leagueID)
        {
            throw new NotImplementedException();
        }
    }
}
