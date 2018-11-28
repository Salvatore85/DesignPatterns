using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface IObserver
    {
        void update(float temp, float humidity, float pressure);
    }
}
