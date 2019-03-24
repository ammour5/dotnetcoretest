using System;

using TechTalk.SpecFlow;

namespace backend.Tests.Registration
{
    [Binding]
    public class PlayerSteps
    {
        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
 
            ScenarioContext.Current.Pending();
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
    }
}
