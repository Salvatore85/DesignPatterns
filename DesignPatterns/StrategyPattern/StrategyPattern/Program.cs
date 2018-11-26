using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();

            mallard.PerformQuack();
            mallard.PerformFly();
        }
    }
}
