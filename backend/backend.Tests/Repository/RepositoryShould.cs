using System;
using backend.Data.Repository;
using Xunit;

namespace backend.Tests.Repository
{
    public class RepositoryShould
    {
        private readonly IBankRepository _bankRepository;

        public RepositoryShould()
        {
            // add inmemory db context
            _bankRepository = new BankRepository(null);
        }

        [Fact]
        public void RepositoryNotNull()
        {
            Assert.NotNull(_bankRepository);
        }
    }
}
