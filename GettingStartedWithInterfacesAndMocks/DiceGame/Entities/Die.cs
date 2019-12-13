using GettingStartedWithInterfacesAndMocks.DiceGame.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace GettingStartedWithInterfacesAndMocks.DiceGame.Entities
{
    public class Die
    {
        public Die()
        {
            Roll();
        }

        public int Value { get; private set; }
        public void Roll()
        {
            Value = DieRoller.GetD6Roll();
        }
    }
}
