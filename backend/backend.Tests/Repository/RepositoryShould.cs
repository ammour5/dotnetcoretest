using System;
using backend.Data.Repository;
using Xunit;

namespace backend.Tests.Repository
{
    [Trait("Repository","")]
    public class RepositoryShould
    {
        private readonly IBankRepository _bankRepository;

        public RepositoryShould()
        {
            // add inmemory db context
            _bankRepository = new BankRepository(null);
        }

        [Fact(DisplayName="repo not null")]
        public void RepositoryNotNull()
        {
            Assert.NotNull(_bankRepository);
        }

        [Fact(DisplayName = "repo null")]
        public void RepositoryNo()
        {
            throw new NotImplementedException("ok");
        }
    }
}
