using StrategyPattern.Behaviors.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quick();
        }

        public void Swim()
        {
            Console.WriteLine("I'm swimming.");
        }

        public virtual void Display()
        {
            Console.WriteLine("I'm a duck.");
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            FlyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            QuackBehavior = qb;
        }
    }
}
