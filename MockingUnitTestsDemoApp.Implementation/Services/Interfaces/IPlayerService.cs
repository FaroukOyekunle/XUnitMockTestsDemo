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
        Player GetByID(int id);

        List<Player> GetForLeague(int leagueID);
    }
}
