using StrategyPattern.Behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new NoFly();
            QuackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
