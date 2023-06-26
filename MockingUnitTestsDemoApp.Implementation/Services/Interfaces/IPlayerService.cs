using MockingUnitTestsDemoApp.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingUnitTestsDemoApp.Implementation.Services.Interfaces
{
    public interface IPlayerService
    {
        // Declare a method signature for getting a player by ID
        Player GetByID(int id);

        // Declare a method signature for getting players for a specific league
        List<Player> GetForLeague(int leagueID);
    }
}