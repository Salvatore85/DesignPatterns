﻿using ObserverPattern.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        public void NotifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                var observer = (IObserver)observers;
                observer.update(temperature, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(i);
            }
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            MeasurementsChanged();
        }
    }
}
