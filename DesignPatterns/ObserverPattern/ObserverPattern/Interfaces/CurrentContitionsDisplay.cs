using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public class CurrentContitionsDisplay : IObserver, IDisplayElement
    {
        public void Display()
        {
            throw new NotImplementedException();
        }

        public void update(float temp, float humidity, float pressure)
        {
            throw new NotImplementedException();
        }
    }
}
