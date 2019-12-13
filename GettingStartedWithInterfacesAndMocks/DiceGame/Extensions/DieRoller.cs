using System;

namespace GettingStartedWithInterfacesAndMocks.DiceGame.Extensions
{
    public static class DieRoller
    {
        static Random _rng = new Random();

        public static int GetD6Roll()
        {
            return _rng.Next(1, 7);
        }

    }
}
