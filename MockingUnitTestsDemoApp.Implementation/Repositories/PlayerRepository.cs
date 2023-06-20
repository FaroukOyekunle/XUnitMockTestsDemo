// Added PlayerRepository class that implements the IPlayerRepository interface
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
    public class PlayerRepository : IPlayerRepository
    {
        // Placeholder implementation for GetByID method
        public Player GetByID(int id)
        {
            throw new NotImplementedException();
        }

        // Placeholder implementation for GetForTeam method
        public List<Player> GetForTeam(int id)
        {
            throw new NotImplementedException();
        }
    }
}