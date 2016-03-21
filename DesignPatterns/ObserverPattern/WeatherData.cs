using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherData : Subject
    {
        private List<Observer> _observerse;

        private float _temp;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observerse = new List<Observer>();
        }

        public void NotifyObserver()
        {
            for (int i = 0; i < _observerse.Count; i++)
            {
                Observer Observer = (Observer)_observerse[i];
                Observer.Update(_temp,_humidity,_pressure);
            }
        }

        public void RegisterObserver(Observer O)
        {
            _observerse.Add(O);
        }

        public void RemoveObserver(Observer O)
        {
            int i = _observerse.IndexOf(O);
            if(i >= 0)
            {
                _observerse.Remove(O);
            }
        }

        public void MeasurementChange()
        {
            NotifyObserver();
        }

        public void SetMeasurement(float temp , float hum , float pres)
        {
            _temp = temp;
            _pressure = pres;
            _humidity = hum;
            MeasurementChange();
        }

        
    }
}
