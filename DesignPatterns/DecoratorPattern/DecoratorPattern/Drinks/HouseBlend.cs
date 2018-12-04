using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public override double Cost()
        {
            return .89;
        }

        public override string GetDescription()
        {
            return "House Blend";
        }
    }
}
