using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public abstract string GetDescription();

        public abstract double Cost();
    }

}
