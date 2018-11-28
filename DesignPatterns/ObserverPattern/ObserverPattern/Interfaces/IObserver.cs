using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface Observer
    {
        void update(float temp, float humidity, float pressure);
    }
}
