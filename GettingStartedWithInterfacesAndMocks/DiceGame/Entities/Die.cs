using GettingStartedWithInterfacesAndMocks.DiceGame.Extensions;
using GettingStartedWithInterfacesAndMocks.DiceGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GettingStartedWithInterfacesAndMocks.DiceGame.Entities
{
    public class Die : IDie
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
