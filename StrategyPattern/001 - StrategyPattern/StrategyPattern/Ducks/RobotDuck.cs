using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class RobotDuck : Duck
    {
        public RobotDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyWithRocket();
            swimBehavior = new SwimNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Robot Duck");
        }
    }
}
