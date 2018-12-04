using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public override double Cost()
        {
            return .99;
        }

        public override string GetDescription()
        {
            return "Dark Roast";
        }
    }
}
