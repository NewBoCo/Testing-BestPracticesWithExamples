using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WhatShouldITest.Utilities;

namespace WhatShouldITestTests
{
    [TestClass]
    public class MenuUtilityTests
    {
        [TestMethod]
        public void GetDailySpecial_ItIsMonday_ShouldReturnHalfPriceTacos()
        {
            MenuUtilities.GetDailySpecial(DayOfWeek.Monday).Should().Be("Half price tacos!");
        }
    }
}
