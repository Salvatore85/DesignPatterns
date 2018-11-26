using StrategyPattern.Behaviors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Behaviors
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying wiht a rocket!");
        }
    }
}
