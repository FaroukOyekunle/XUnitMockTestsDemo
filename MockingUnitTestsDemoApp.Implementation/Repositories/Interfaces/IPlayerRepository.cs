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
        Player GetByID(int id);
        List<Player> GetForTeam(int id);
    }
}
