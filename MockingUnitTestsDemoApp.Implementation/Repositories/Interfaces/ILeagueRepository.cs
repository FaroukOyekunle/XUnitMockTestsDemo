// Added ILeagueRepository interface to define the contract for League repositories
// Specifies the methods to get league by ID, get all leagues, and validate a league ID

using MockingUnitTestsDemoApp.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingUnitTestsDemoApp.Implementation.Repositories.Interfaces
{
    public interface ILeagueRepository
    {
        // Method to get a league by its ID
        League GetByID(int id);
        
        // Method to get all leagues
        List<League> GetAll();
        
        // Method to validate a league ID
        bool IsValid(int leagueID);
    }
}