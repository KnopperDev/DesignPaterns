using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData) 
        { 
           this.weatherData = weatherData;
           weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Forecast: More of the same: {temperature}F degrees and {humidity}% humidity and {pressure} Pa pressure");
        }
    }
}
