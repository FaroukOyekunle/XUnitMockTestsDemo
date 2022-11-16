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
        public Player GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetForTeam(int id)
        {
            throw new NotImplementedException();
        }
    }
}
