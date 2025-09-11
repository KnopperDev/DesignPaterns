using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.SwimBehavior
{
    internal class Drifting : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("Drifting into the distance");
        }
    }
}
