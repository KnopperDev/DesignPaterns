using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Theater Ceiling Lights are On");
        }

        public void Off()
        {
            Console.WriteLine("Theater Ceiling Lights are Off");
        }

        public void Dim(int value)
        {
            Console.WriteLine($"Theater Ceiling Lights dimming to {value}%");
        }
    }
}
