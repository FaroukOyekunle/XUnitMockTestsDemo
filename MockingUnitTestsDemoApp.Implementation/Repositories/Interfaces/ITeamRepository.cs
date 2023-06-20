// Added ITeamRepository interface to define the contract for Team repositories
// Specifies the methods to get a team by ID and get all teams for a league

using MockingUnitTestsDemoApp.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingUnitTestsDemoApp.Implementation.Repositories.Interfaces
{
    public interface ITeamRepository
    {
        // Method to get a team by its ID
        Team GetByID(int id);
        
        // Method to get all teams for a league by league ID
        List<Team> GetForLeague(int leagueID);
    }
}