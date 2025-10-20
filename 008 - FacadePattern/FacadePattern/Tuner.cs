using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Tuner
    {
        private Amplifier _amplifier;
        public Tuner(Amplifier amplifier)
        {
            this._amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Tuner on");
        }

        public void Off()
        {
            Console.WriteLine("Tuner off");
        }

        public void setAM()
        {
            Console.WriteLine("Tuner setting AM");
        }

        public void setFM()
        {
            Console.WriteLine("Tuner setting FM");
        }

        public void setFrequency()
        {
            Console.WriteLine("Tuner setting frequency");
        }

    }
}
