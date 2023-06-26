using MockingUnitTestsDemoApp.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingUnitTestsDemoApp.Implementation.Services.Interfaces
{
    public interface ILeagueService
    {
        // Declare a method signature for checking if a league ID is valid
        bool IsValid(int id);

        // Declare a method signature for getting all leagues
        List<League> GetAll();
    }
}
