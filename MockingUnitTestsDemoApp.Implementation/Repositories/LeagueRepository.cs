// Added LeagueRepository class that implements the ILeagueRepository interface
// Contains placeholder implementations for the interface methods

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
        // Placeholder implementation for GetByID method
        public League GetByID(int leagueID)
        {
            throw new NotImplementedException();
        }

        // Placeholder implementation for GetAll method
        public List<League> GetAll()
        {
            throw new NotImplementedException();
        }

        // Placeholder implementation for IsValid method
        public bool IsValid(int leagueID)
        {
            throw new NotImplementedException();
        }
    }
}