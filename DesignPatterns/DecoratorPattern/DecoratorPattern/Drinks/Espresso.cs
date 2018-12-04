using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double Cost()
        {
            throw new NotImplementedException();
        }
    }
}
