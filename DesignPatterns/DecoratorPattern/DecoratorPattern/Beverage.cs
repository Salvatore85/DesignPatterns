using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        string description = "Unknown Beverage";

        public string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }

}
