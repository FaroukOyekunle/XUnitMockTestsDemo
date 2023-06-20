// Added IPlayerRepository interface to define the contract for Player repositories
// Specifies the methods to get a player by ID and get all players for a team

using MockingUnitTestsDemoApp.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingUnitTestsDemoApp.Implementation.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        // Method to get a player by its ID
        Player GetByID(int id);
        
        // Method to get all players for a team by team ID
        List<Player> GetForTeam(int id);
    }
}