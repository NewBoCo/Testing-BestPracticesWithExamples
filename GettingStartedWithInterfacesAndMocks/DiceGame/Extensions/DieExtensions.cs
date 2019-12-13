using GettingStartedWithInterfacesAndMocks.DiceGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GettingStartedWithInterfacesAndMocks.DiceGame.Extensions
{
    public static class DieExtensions
    {
        public static bool IsValidRoll(this IEnumerable<Die> dice)
        {
            return dice.Count() == 5;
        }

        public static bool IsFiveOfAKind(this IEnumerable<Die> dice)
        {
            throw new NotImplementedException();
        }
    }
}
