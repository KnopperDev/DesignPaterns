using Bev = DecoratorPattern.Beverages;
using Cond = DecoratorPattern.Condiments;


namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bev.Beverage espresso = new Bev.Espresso();
            PrintBeverage(espresso);

            Bev.Beverage lungo = new Bev.Espresso();
            lungo = new Cond.Water(lungo);
            PrintBeverage(lungo);

            Bev.Beverage americano = new Bev.Espresso();
            americano = new Cond.Water(americano);
            americano = new Cond.Water(americano);
            PrintBeverage(americano);

            Bev.Beverage whiskey = new Bev.Water();
            whiskey = new Cond.Whiskey(whiskey);
            PrintBeverage(whiskey);
        }

        static void PrintBeverage(Bev.Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.cost().ToString("#.##"));
        }
    }
}