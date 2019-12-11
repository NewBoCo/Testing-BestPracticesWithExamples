using System;
using TechTalk.SpecFlow;

namespace GettingStarted
{
    [Binding]
    public class AddTwoNumbersTogetherSteps
    {
        [Given(@"I have entered the numbers (.*) and (.*)")]
        public void GivenIHaveEnteredTheNumbersAnd(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I add (.*) and (.*) together")]
        public void WhenIAddAndTogether(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
