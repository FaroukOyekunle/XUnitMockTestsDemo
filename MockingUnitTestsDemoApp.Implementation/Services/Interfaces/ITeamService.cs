using MockingUnitTestsDemoApp.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingUnitTestsDemoApp.Implementation.Services.Interfaces
{
    public interface ITeamService
    {
        List<Team> Search(TeamSearch search);
    }
}
