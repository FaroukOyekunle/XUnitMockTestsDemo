using MockingUnitTestsDemoApp.Implementation.Models;
using MockingUnitTestsDemoApp.Implementation.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingUnitTestsDemoApp.Implementation.Repositories
{
    public class LeagueRepository : ILeagueRepository
    {
        public League GetByID(int leagueID)
        {
            throw new NotImplementedException();
        }

        public List<League> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool IsValid(int leagueID)
        {
            throw new NotImplementedException();
        }
    }
}
