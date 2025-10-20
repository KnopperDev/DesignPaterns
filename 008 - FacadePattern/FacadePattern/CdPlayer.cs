using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class CdPlayer
    {
        private Amplifier _amplifier;
        public CdPlayer(Amplifier amplifier)
        {
            this._amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Cd Player on");
        }
        public void Off()
        {
            Console.WriteLine("Cd Player off");
        }
        public void Eject()
        {
            Console.WriteLine("Cd Player eject");
        }
        public void Pause()
        {
            Console.WriteLine("Cd Player pause");
        }
        public void Play()
        {
            Console.WriteLine("Cd Player playing");
        }
        public void Stop()
        {
            Console.WriteLine("Cd Player stop");
        }
    }
}
