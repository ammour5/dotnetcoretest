using System;
using backend.Data.Repository;
using Xunit;

namespace backend.Tests.Repository
{
    public class RepositoryShould
    {
        private readonly IBankRepository _bankRepository;

        public RepositoryShould(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }

        [Fact]
        public void RepositoryNotNull()
        {
 

            Assert.NotNull(_bankRepository);
        }
    }
}
