using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class ChocolateBoiler
    {
        private static readonly Lazy<ChocolateBoiler> Lazy = 
            new Lazy<ChocolateBoiler>(() => new ChocolateBoiler(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        private bool Empty;
        private bool Boiled;

        public void Fill()
        {
            if (isEmpty())
            {
                Empty = false;
                Boiled = false;
            }
        }

        public void Drain()
        {
            if (!isEmpty() && isBoild())
            {
                Empty = true;
            }
        }

        private bool isBoild()
        {
            return Boiled;
        }

        private bool isEmpty()
        {
            return Empty;
        }
    }
}
