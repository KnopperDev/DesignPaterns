using FactoryPattern.Stores;
using FactoryPattern.Interfaces.Factories;
using Bev = FactoryPattern.Beverages;
using Con = FactoryPattern.Condiments;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageStore store = new BeverageStore(new BeverageFactory());

            Console.WriteLine("Welcome to the Coffee Shop! Here is our menu:");

            Console.WriteLine("=============================================== Tall =============================================");
            Bev::Beverage TallEspresso = store.OrderBeverage("Espresso", "tall");
            Console.Write("\n\n\n");

            Console.WriteLine("=============================================== Grande =============================================");
            Bev::Beverage Espresso = store.OrderBeverage("Espresso");
            Bev::Beverage Doppio = store.OrderBeverage("Doppio");
            Bev::Beverage Lungo = store.OrderBeverage("Lungo");
            Bev::Beverage Macchiato = store.OrderBeverage("Macchiato");
            Bev::Beverage Corretta = store.OrderBeverage("Corretta");
            Bev::Beverage ConPanna = store.OrderBeverage("Con Panna");
            Bev::Beverage Cappucinno = store.OrderBeverage("Cappucinno");
            Bev::Beverage Americano = store.OrderBeverage("Americano");
            Bev::Beverage CafféLatte = store.OrderBeverage("CafféLatte");
            Bev::Beverage FlatWhite = store.OrderBeverage("FlatWhite");
            Bev::Beverage Romana = store.OrderBeverage("Romana");
            Bev::Beverage Morocchino = store.OrderBeverage("Morocchino");
            Bev::Beverage Mocha = store.OrderBeverage("Mocha");
            Bev::Beverage Bicerin = store.OrderBeverage("Bicerin");
            Bev::Beverage Breve = store.OrderBeverage("Breve");
            Bev::Beverage RafCoffee = store.OrderBeverage("RafCoffee");
            Bev::Beverage MeadRaf = store.OrderBeverage("MeadRaf");
            Bev::Beverage Galao = store.OrderBeverage("Galao");
            Bev::Beverage CafféAffogato = store.OrderBeverage("CafféAffogato");
            Bev::Beverage ViennaCoffee = store.OrderBeverage("ViennaCoffee");
            Bev::Beverage Glace = store.OrderBeverage("Glace");
            Bev::Beverage ChocolateMilk = store.OrderBeverage("ChocolateMilk");
            Bev::Beverage DemiCreme = store.OrderBeverage("DemiCreme");
            Bev::Beverage LatteMacchiato = store.OrderBeverage("LatteMacchiato");
            Bev::Beverage Freddo = store.OrderBeverage("Freddo");
            Bev::Beverage Frappuccino = store.OrderBeverage("Frappuccino");
            Bev::Beverage CaramelFrappuccino = store.OrderBeverage("CaramelFrappuccino");
            Bev::Beverage Frappe = store.OrderBeverage("Frappe");
            Bev::Beverage IrishCoffee = store.OrderBeverage("IrishCoffee");
            Console.Write("\n\n\n");

            Console.WriteLine("=============================================== Vendi =============================================");
            Bev::Beverage VendiEspresso = store.OrderBeverage("Espresso", "vendi");
            Console.Write("\n\n\n");



        }
    }
}