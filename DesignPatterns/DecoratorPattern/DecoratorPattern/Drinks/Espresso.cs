using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public override double Cost()
        {
            return 1.99;
        }

        public override string GetDescription()
        {
            return "Espresso";
        }
    }
}
