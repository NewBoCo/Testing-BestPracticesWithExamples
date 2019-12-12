using FluentAssertions;
using SomeStuffToTest;
using System;
using TechTalk.SpecFlow;

namespace GettingStarted
{
    [Binding]
    public class CheckToSeeIfTheStoreIsOpen_OutlineVersionSteps
    {
        DateTime dateToTest;

        [Given(@"it is a certain (.*) and (.*)")]
        public void GivenItIsACertainAnd(string p0, string p1)
        {
            dateToTest = DateTime.Parse($"{p0} {p1}");
        }

        [Then(@"The store (.*) open at that time")]
        public void ThenTheStoreOpen(string p0)
        {
            if (dateToTest.IsStoreOpen())
            {
                p0.ToLower().Replace(" ", "").Should().Be("is");
            }
            else
            {
                p0.ToLower().Replace(" ", "").Should().Be("isnot");
            }
        }
    }
}
