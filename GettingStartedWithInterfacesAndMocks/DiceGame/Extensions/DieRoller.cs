using GettingStartedWithInterfacesAndMocks.DiceGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GettingStartedWithInterfacesAndMocks.DiceGame.Extensions
{
    public static class DieRoller
    {
        static Random _rng = new Random();

        public static int GetD6Roll()
        {
            return _rng.Next(1, 7);
        }

        public static IEnumerable<Die> GetGameRoll()
        {
            return Enumerable.Range(1, 5).Select(_ => new Die());
        }
    }
}
