using StrategyPattern.Behaviors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying the natural ways (with my wings).");
        }
    }
}
