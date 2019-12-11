using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace GettingStarted
{
    [Binding]
    public class AddTwoNumbersTogetherSteps
    {
        int firstNumber;
        int secondNumber;
        int resultOfAddition;

        [Given(@"I have entered the numbers 1 and 2")]
        public void GivenIHaveEnteredTheNumbersOneAndTwo()
        {
            firstNumber = 1;
            secondNumber = 2;
        }

        [When(@"I add 1 and 2 together")]
        public void WhenIAddOneAndTwoTogether()
        {
            resultOfAddition = firstNumber + secondNumber;
        }

        [Then(@"the result should be 3")]
        public void ThenTheResultShouldBeThree()
        {
            resultOfAddition.Should().Be(3);
        }
    }
}
