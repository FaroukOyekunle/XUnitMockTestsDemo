using MockingUnitTestsDemoApp.Implementation.Repositories.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingUnitTestsDemoApp.Tests.Mocks.Repositories
{
    public class MockLeagueRepository : Mock<ILeagueRepository>
    {
        public MockLeagueRepository MockIsValid(bool result)
        {
            Setup(x => x.IsValid(It.IsAny<int>()))
                .Returns(result);

            return this;
        }

        public MockLeagueRepository VerifyIsValid(Times times)
        {
            Verify(x => x.IsValid(It.IsAny<int>()), times);

            return this;
        }
    }
}
