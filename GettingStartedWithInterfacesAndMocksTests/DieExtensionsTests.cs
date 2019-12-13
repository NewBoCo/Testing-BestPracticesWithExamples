using FluentAssertions;
using GettingStartedWithInterfacesAndMocks.DiceGame.Entities;
using GettingStartedWithInterfacesAndMocks.DiceGame.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace GettingStartedWithInterfacesAndMocksTests
{
    [TestClass]
    public class DieExtensionsTests
    {
        [TestMethod]
        public void IsValidRoll_RollHas4Dice_ReturnsFalse()
        {
            var dice = Enumerable.Range(1, 4).Select(_ => new Die());

            dice.IsValidRoll().Should().BeFalse(because: "A valid game roll has five dice");
        }

        [TestMethod]
        public void IsValidRoll_RollHas5Dice_ReturnsTrue()
        {
            var dice = Enumerable.Range(1, 5).Select(_ => new Die());

            dice.IsValidRoll().Should().BeTrue(because: "A valid game roll has five dice");
        }
    }
}
