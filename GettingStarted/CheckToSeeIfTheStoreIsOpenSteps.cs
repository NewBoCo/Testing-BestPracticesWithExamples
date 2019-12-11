using FluentAssertions;
using SomeStuffToTest;
using System;
using TechTalk.SpecFlow;

namespace GettingStarted
{
    [Binding]
    public class CheckToSeeIfTheStoreIsOpenSteps
    {
        DateTime currentTime;

        [Given(@"It is currently (.*) at (.*)")]
        public void GivenItIsCurrentlyAt(string p0, string p1)
        {
            currentTime = DateTime.Parse($"{p0} {p1}");
        }

        [Then(@"The store is open")]
        public void ThenTheStoreIsOpen()
        {
            currentTime.IsStoreOpen().Should().BeTrue();
        }

        [Then(@"The store is closed")]
        public void ThenTheStoreIsClosed()
        {
            currentTime.IsStoreOpen().Should().BeFalse();
        }

    }
}
