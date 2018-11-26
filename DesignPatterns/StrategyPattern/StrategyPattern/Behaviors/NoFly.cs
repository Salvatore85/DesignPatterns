using StrategyPattern.Behaviors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Behaviors
{
    public class NoFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly.");
        }
    }
}
