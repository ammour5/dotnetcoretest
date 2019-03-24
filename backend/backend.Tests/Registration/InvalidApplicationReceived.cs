using System;
using Xunit;

namespace backend.Tests.Registration
{


    [Trait("An invalid Application is received","")]
    public class InvalidApplicationReceived
    {
        [Fact(DisplayName ="Application is denied")]
        public void UserDenied()
        {
            throw new NotImplementedException("Implement me");
        }


        [Fact(DisplayName ="A message os shown explianing why")]
        public void MessageIsShown()
        {
            throw new NotImplementedException("Implement me");
        }

    }
}
