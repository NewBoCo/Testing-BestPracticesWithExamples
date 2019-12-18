using GettingStartedWithInterfacesAndMocks.DiceGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GettingStartedWithInterfacesAndMocksTests.TestingMocks
{
    public class SettableD6 : IDie
    {
        public SettableD6(int value)
        {
            Value = value;
        }

        public int Value { get; set; }

        public void Roll()
        {
            //Does nothing
        }
    }
}
