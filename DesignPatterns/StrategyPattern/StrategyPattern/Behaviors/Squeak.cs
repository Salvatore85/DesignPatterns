using StrategyPattern.Behaviors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Behaviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quick()
        {
            Console.WriteLine("I make a squaky sound.");
        }
    }
}
