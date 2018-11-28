using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface ISubject
    {
        void RegisterObserver(Observer o);
        void RemoveObserver(Observer o);
        void NotifyObserver();
    }
}
