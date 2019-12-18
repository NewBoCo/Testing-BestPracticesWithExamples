using GettingStartedWithInterfacesAndMocks.DiceGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GettingStartedWithInterfacesAndMocks.DiceGame.Extensions
{
    public static class DieExtensions
    {
        public static bool IsValidRoll(this IEnumerable<IDie> dice)
        {
            return dice.Count() == 5;
        }

        public static bool IsFiveOfAKind(this IEnumerable<IDie> dice)
        {
            if (!dice.IsValidRoll())
            {
                throw new ArgumentException("A valid roll must contain exactly five dice");
            }

            return dice.GroupBy(d => d.Value).Count() == 1;
        }
    }
}
