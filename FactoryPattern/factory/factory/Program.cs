using System;
using DecoratorPattern.Beverages;
using DecoratorPattern.Factory;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Available beverages:");
            foreach (var name in Enum.GetNames(typeof(BeverageType)))
            {
                Console.WriteLine(" - " + name);
            }

            Console.WriteLine("\nWhich beverage would you like?");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out BeverageType choice))
            {
                try
                {
                    Beverage drink = BeverageFactory.CreateBeverage(choice);
                    PrintBeverage(drink);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }
}
