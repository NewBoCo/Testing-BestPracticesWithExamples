using System;

namespace GettingStartedWithInterfacesAndMocks.DiceGame.Interfaces
{
    public interface IDie
    {
        void Roll();
        int Value { get; }
    }
}
