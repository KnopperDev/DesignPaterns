using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;
        public DvdPlayer(Amplifier amplifier)
        {
            this._amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Dvd Player on");
        }
        public void Off()
        {
            Console.WriteLine("Dvd Player off");
        }
        public void Eject()
        {
            Console.WriteLine("Dvd Player eject");
        }
        public void Pause()
        {
            Console.WriteLine("Dvd Player pause");
        }
        public void Play(string movie)
        {
            Console.WriteLine("Dvd Player playing \"" + movie + "\"");
        }
        public void SetSurroundAudio()
        {
            Console.WriteLine("Dvd Player set surround audio");
        }
        public void SetTWoChannelAudio()
        {
            Console.WriteLine("Dvd Player set two channel audio");
        }
        public void Stop()
        {
            Console.WriteLine("Dvd Player stop");
        }
    }
}
