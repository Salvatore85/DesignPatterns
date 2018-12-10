using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class ChocolateBoiler
    {
        private static ChocolateBoiler chocolateBoiler;

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        private bool Empty;
        private bool Boiled;

        public static ChocolateBoiler Instance ()
        {
            if(chocolateBoiler == null) 
            {
                chocolateBoiler = new ChocolateBoiler();
            }

            return chocolateBoiler;
        }
    }
}
