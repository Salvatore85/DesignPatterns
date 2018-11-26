using StrategyPattern.Behaviors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Behaviors
{
    public class Quack : IQuackBehavior
    {
        public void Quick()
        {
            Console.WriteLine("Quicking like a normal duck.");
        }
    }
}
