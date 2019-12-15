using FluentAssertions;
using GettingStartedWithInterfacesAndMocks.DiceGame.Entities;
using GettingStartedWithInterfacesAndMocks.DiceGame.Extensions;
using GettingStartedWithInterfacesAndMocksTests.TestingMocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void IsFiveOfAKind_AllDiceAreTheSame_ReturnsTrue()
        {
            var dice = Enumerable.Range(1, 5).Select(_ => new SettableD6(5));

            dice.IsFiveOfAKind().Should().BeTrue();
        }

        [TestMethod]
        public void IsFiveOfAKind_AllDiceAreNotTheSame_ReturnsFalse()
        {
            var dice = new[]{
                new SettableD6(1),
                new SettableD6(3),
                new SettableD6(4),
                new SettableD6(1),
                new SettableD6(1)
            };

            dice.IsFiveOfAKind().Should().BeFalse();
        }

        [TestMethod]
        public void IsFiveOfAKind_NotAValidRoll_ThrowsArgumentException()
        {
            var dice = new[]{
                new SettableD6(2),
                new SettableD6(3)
            };

            Action validateRoll = () => dice.IsFiveOfAKind();

            validateRoll.Should().Throw<ArgumentException>();
        }
    }
}
