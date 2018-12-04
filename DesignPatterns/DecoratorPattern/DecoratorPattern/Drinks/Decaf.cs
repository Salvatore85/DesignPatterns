using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Decaf : Beverage
    {
        public override double Cost()
        {
            return 1.05;
        }

        public override string GetDescription()
        {
            return "Decaf";
        }
    }
}
