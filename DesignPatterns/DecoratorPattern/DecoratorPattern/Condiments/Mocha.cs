using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return .20 + Beverage.Cost();
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Mocha";
        }
    }
}
