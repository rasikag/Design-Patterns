﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ForecastDisplay : Observer, DisplayElement
    {
        private float _temp;
        private float _humidity;
        private Subject _weatherData;

        public ForecastDisplay(Subject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Forecast Display : {0} F degree and {1} % humidity", _temp, _humidity);

        }

        public void Update(float Temp, float Humidity, float Pressure)
        {
            _temp = Temp;
            _humidity = Humidity;
            Display();
        }

    }
}
