using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.Swim();

            // Change behavior at runtime
            Console.WriteLine("The mallard got tired and can't fly anymore.");
            mallardDuck.SetFlyBehavior(new FlyNoWay());
            mallardDuck.PerformFly();

            Console.WriteLine("Look a jetpack!");
            mallardDuck.SetFlyBehavior(new FlyWithRocket());
            mallardDuck.PerformFly();
            Console.WriteLine("-----------------------------");

            Duck redheadDuck = new RedheadDuck();
            redheadDuck.Display();
            redheadDuck.PerformQuack();
            redheadDuck.Swim();
            Console.WriteLine("-----------------------------");

            Duck decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.PerformQuack();
            decoyDuck.Swim();
            Console.WriteLine("-----------------------------");

            Duck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.PerformFly();
            rubberDuck.Swim();
            Console.WriteLine("-----------------------------");

            Duck robotDuck = new RobotDuck();
            robotDuck.Display();
            robotDuck.PerformFly();
            robotDuck.Swim();
            Console.WriteLine("-----------------------------");
        }
    }
}
