using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Whip : CondimentDecorator
    {
        public override double Cost()
        {
            throw new NotImplementedException();
        }

        public override string GetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
