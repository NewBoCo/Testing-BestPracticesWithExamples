using System;
using TechTalk.SpecFlow;

namespace GettingStarted
{
    [Binding]
    public class TestAddingNumbersWithVariablesSteps
    {
        [Given(@"I have the numbers (.*) and (.*)")]
        public void GivenIHaveTheNumbersAnd(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I add them together")]
        public void WhenIAddThemTogether()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"they should add up to (.*)")]
        public void ThenTheyShouldAddUpTo(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
