using StrategyPattern.Behaviors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quick()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
