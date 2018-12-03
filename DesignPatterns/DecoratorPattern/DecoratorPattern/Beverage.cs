using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        string description = "Unnkown Beverage";

        public string Get Description()
        {
            return description;
        }

        public abstract double Cost();
    }

}
