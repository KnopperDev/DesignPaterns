using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        private Subject weatherData;
        public StatisticsDisplay(Subject weatherData) 
        { 
           this.weatherData = weatherData;
           weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.sumTemperature += temp;
            this.countUpdated++;

            if (countUpdated == 1)
            {
                this.maxTemp = temp;
                this.minTemp = temp;
            }
            else
            {
                if (temp > maxTemp)
                {
                    this.maxTemp = temp;
                }
                if (temp < minTemp)
                {
                    this.minTemp = temp;
                }
            }
            Display();
        }

        public void Display()
        {
            float avgTemp = sumTemperature / countUpdated;
            Console.WriteLine($"Avg/Max/Min temperature = {avgTemp}/{maxTemp}/{minTemp}");
        }
    }
}
