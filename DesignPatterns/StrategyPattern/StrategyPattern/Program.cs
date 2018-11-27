using StrategyPattern.Behaviors;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new ModelDuck();

            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
