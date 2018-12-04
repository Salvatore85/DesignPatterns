using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Milk : CondimentDecorator
    {
        public override double Cost()
        {
            return .10 + Beverage.Cost();
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Milk";
        }
    }
}
