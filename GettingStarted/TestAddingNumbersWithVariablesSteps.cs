using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace GettingStarted
{
    [Binding]
    public class TestAddingNumbersWithVariablesSteps
    {
        int firstNumber;
        int secondNumber;
        int resultOfAddition;

        [Given(@"I have the numbers (.*) and (.*)")]
        public void GivenIHaveTheNumbersAnd(int p0, int p1)
        {
            firstNumber = p0;
            secondNumber = p1;
        }

        [When(@"I add them together")]
        public void WhenIAddThemTogether()
        {
            resultOfAddition = firstNumber + secondNumber;
        }

        [Then(@"they should add up to (.*)")]
        public void ThenTheyShouldAddUpTo(int p0)
        {
            resultOfAddition.Should().Be(p0);
        }
    }
}
