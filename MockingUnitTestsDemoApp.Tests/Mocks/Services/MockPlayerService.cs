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
    public class MockPlayerService : Mock<IPlayerService>
    {
        public MockPlayerService MockGetByID(Player result)
        {
            Setup(x => x.GetByID(It.IsAny<int>()))
                .Returns(result);

            return this;
        }

        public MockPlayerService MockGetByIDInvalid()
        {
            Setup(x => x.GetByID(It.IsAny<int>()))
                .Throws(new Exception("Player with that ID was not found!"));

            return this;
        }

        public MockPlayerService VerifyGetByID(Times times)
        {
            Verify(x => x.GetByID(It.IsAny<int>()), times);

            return this;
        }

        public MockPlayerService MockGetForLeague(List<Player> results)
        {
            Setup(x => x.GetForLeague(It.IsAny<int>()))
                .Returns(results);

            return this;
        }

        public MockPlayerService VerifyGetForLeague(Times times)
        {
            Verify(x => x.GetForLeague(It.IsAny<int>()), times);

            return this;
        }
    }
}
