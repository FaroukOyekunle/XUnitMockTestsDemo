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
        League GetByID(int id);
        List<League> GetAll();
        bool IsValid(int leagueID);
    }
}
