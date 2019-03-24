using System;
using Xunit;

namespace backend.Tests.Registration
{
    [Trait("An Application is received with empty email or password", "")]
    public class EmptyEmailOrPassword
    {

        [Fact(DisplayName = "Application considered invalid")]
        public void FactName()
        {
            throw new NotImplementedException("Implement me");
        }

        [Fact(DisplayName = "A message is returned")]
        public void MessageReturned()
        {
            throw new NotImplementedException("Implmeent me");
        }
    }
}
