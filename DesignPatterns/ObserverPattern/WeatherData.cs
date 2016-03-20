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

        public void NotifyObserver(Observer O)
        {

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
    }
}
