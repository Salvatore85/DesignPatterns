using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Ingredients
{
    public class Cheese : ICheese
    {
        public string Name
        {
            get { return "Reggiano Cheese"; }
        }
    }
}
