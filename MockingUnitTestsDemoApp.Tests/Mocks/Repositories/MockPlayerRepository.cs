using MockingUnitTestsDemoApp.Implementation.Models;
using MockingUnitTestsDemoApp.Implementation.Repositories.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingUnitTestsDemoApp.Tests.Mocks.Repositories
{
    public class MockPlayerRepository : Mock<IPlayerRepository>
    {
        public MockPlayerRepository MockGetByID(Player result)
        {
            Setup(x => x.GetByID(It.IsAny<int>()))
                .Returns(result);

            return this;
        }

        public MockPlayerRepository MockGetForTeam(List<Player> results)
        {
            Setup(x => x.GetForTeam(It.IsAny<int>()))
                .Returns(results);

            return this;
        }

        public MockPlayerRepository VerifyGetForTeam(Times times)
        {
            Verify(x => x.GetForTeam(It.IsAny<int>()), times);

            return this;
        }
    }
}
