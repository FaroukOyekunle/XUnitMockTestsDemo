using MockingUnitTestsDemoApp.Implementation.Models;
using MockingUnitTestsDemoApp.Implementation.Services.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingUnitTestsDemoApp.Tests.Mocks.Services
{
    public class MockTeamService : Mock<ITeamService>
    {
        public MockTeamService MockSearch(List<Team> results)
        {
            Setup(x => x.Search(It.IsAny<TeamSearch>()))
                .Returns(results);

            return this;
        }

        public MockTeamService VerifySearch(Times times)
        {
            Verify(x => x.Search(It.IsAny<TeamSearch>()), times);

            return this;
        }
    }
}
