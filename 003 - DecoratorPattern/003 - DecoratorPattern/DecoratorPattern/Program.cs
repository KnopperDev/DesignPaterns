using Bev = DecoratorPattern.Beverages;
using Cond = DecoratorPattern.Condiments;


namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bev.Beverage Espresso = new Bev.Espresso();
            PrintBeverage(Espresso);

            Bev.Beverage Doppio = new Bev.Espresso();
            Doppio = new Cond.Espresso(Doppio);
            PrintBeverage(Doppio);

            Bev.Beverage Lungo = new Bev.Espresso();
            Lungo = new Cond.Water(Lungo);
            PrintBeverage(Lungo);

            Bev.Beverage Macchiato = new Bev.Espresso();
            Macchiato = new Cond.MilkFoam(Macchiato);
            PrintBeverage(Macchiato);

            Bev.Beverage Corretta = new Bev.Espresso();
            Corretta = new Cond.Liqour(Corretta);
            PrintBeverage(Corretta);

            Bev.Beverage ConPanna = new Bev.Espresso();
            ConPanna = new Cond.Whip(ConPanna);
            PrintBeverage(ConPanna);

            Bev.Beverage Cappucinno = new Bev.Espresso();
            Cappucinno = new Cond.SteamedMilk(Cappucinno);
            Cappucinno = new Cond.MilkFoam(Cappucinno);
            PrintBeverage(Cappucinno);

            Bev.Beverage Americano = new Bev.Espresso();
            Americano = new Cond.Water(Americano);
            Americano = new Cond.Water(Americano);
            PrintBeverage(Americano);

            Bev.Beverage CafféLatte = new Bev.Espresso();
            CafféLatte = new Cond.SteamedMilk(CafféLatte);
            CafféLatte = new Cond.SteamedMilk(CafféLatte);
            CafféLatte = new Cond.MilkFoam(CafféLatte);
            PrintBeverage(CafféLatte);

            Bev.Beverage FlatWhite = new Bev.Espresso();
            FlatWhite = new Cond.SteamedMilk(FlatWhite);
            FlatWhite = new Cond.SteamedMilk(FlatWhite);
            PrintBeverage(FlatWhite);

            Bev.Beverage Romana = new Bev.Espresso();
            Romana = new Cond.Lemon(Romana);
            PrintBeverage(Romana);

            Bev.Beverage Morocchino = new Bev.Espresso();
            Morocchino = new Cond.Chocolate(Morocchino);
            Morocchino = new Cond.MilkFoam(Morocchino);
            PrintBeverage(Morocchino);

            Bev.Beverage Mocha = new Bev.Espresso();
            Mocha = new Cond.Chocolate(Mocha);
            Mocha = new Cond.SteamedMilk(Mocha);
            Mocha = new Cond.Whip(Mocha);
            PrintBeverage(Mocha);

            Bev.Beverage Bicerin = new Bev.Espresso();
            Bicerin = new Cond.BlackChocolate(Bicerin);
            Bicerin = new Cond.WhiteChocolate(Bicerin);
            Bicerin = new Cond.Whip(Bicerin);
            PrintBeverage(Bicerin);

            Bev.Beverage Breve = new Bev.Espresso();
            Breve = new Cond.MilkFoam(Breve);
            Breve = new Cond.HalfMilk(Breve);
            PrintBeverage(Breve);

            Bev.Beverage RafCoffee = new Bev.Espresso();
            RafCoffee = new Cond.VanillaSugar(RafCoffee);
            RafCoffee = new Cond.Cream(RafCoffee);
            PrintBeverage(RafCoffee);

            Bev.Beverage MeadRaf = new Bev.Espresso();
            MeadRaf = new Cond.Honey(MeadRaf);
            MeadRaf = new Cond.Cream(MeadRaf);
            PrintBeverage(MeadRaf);

            Bev.Beverage Galao = new Bev.Espresso();
            Galao = new Cond.MilkFoam(Galao);
            Galao = new Cond.MilkFoam(Galao);
            PrintBeverage(Galao);

            Bev.Beverage CafféAffogato = new Bev.Espresso();
            CafféAffogato = new Cond.Espresso(CafféAffogato);
            CafféAffogato = new Cond.Icecream(CafféAffogato);
            PrintBeverage(CafféAffogato);

            Bev.Beverage ViennaCoffee = new Bev.Espresso();
            ViennaCoffee = new Cond.Espresso(ViennaCoffee);
            ViennaCoffee = new Cond.Whip(ViennaCoffee);
            ViennaCoffee = new Cond.Whip(ViennaCoffee);
            PrintBeverage(ViennaCoffee);

            Bev.Beverage Glace = new Bev.Espresso();
            Glace = new Cond.Icecream(Glace);
            PrintBeverage(Glace);

            Bev.Beverage ChocolateMilk = new Bev.Espresso();
            ChocolateMilk = new Cond.Milk(ChocolateMilk);
            ChocolateMilk = new Cond.Milk(ChocolateMilk);
            PrintBeverage(ChocolateMilk);

            Bev.Beverage DemiCreme = new Bev.Espresso();
            DemiCreme = new Cond.Espresso(DemiCreme);
            DemiCreme = new Cond.Cream(DemiCreme);
            DemiCreme = new Cond.Cream(DemiCreme);
            PrintBeverage(DemiCreme);

            Bev.Beverage LatteMacchiato = new Bev.Espresso();
            LatteMacchiato = new Cond.SteamedMilk(LatteMacchiato);
            LatteMacchiato = new Cond.SteamedMilk(LatteMacchiato);
            LatteMacchiato = new Cond.MilkFoam(LatteMacchiato);
            PrintBeverage(LatteMacchiato);

            Bev.Beverage Freddo = new Bev.Espresso();
            Freddo = new Cond.Liqour(Freddo);
            Freddo = new Cond.Ice(Freddo);
            PrintBeverage(Freddo);

            Bev.Beverage Frappuccino = new Bev.Espresso();
            Frappuccino = new Cond.Ice(Frappuccino);
            Frappuccino = new Cond.SteamedMilk(Frappuccino);
            Frappuccino = new Cond.Whip(Frappuccino);
            PrintBeverage(Frappuccino);

            Bev.Beverage CaramelFrappuccino = new Bev.Espresso();
            CaramelFrappuccino = new Cond.Ice(CaramelFrappuccino);
            CaramelFrappuccino = new Cond.SteamedMilk(CaramelFrappuccino);
            CaramelFrappuccino = new Cond.Cream(CaramelFrappuccino);
            CaramelFrappuccino = new Cond.Syrup(CaramelFrappuccino);
            PrintBeverage(CaramelFrappuccino);

            Bev.Beverage Frappe = new Bev.Espresso();
            Frappe = new Cond.SteamedMilk(Frappe);
            Frappe = new Cond.SteamedMilk(Frappe);
            Frappe = new Cond.Icecream(Frappe);
            PrintBeverage(Frappe);

            Bev.Beverage VendiIrishCoffee = new Bev.Espresso();
            VendiIrishCoffee.Size = Bev.Size.VENDI;
            VendiIrishCoffee = new Cond.Espresso(VendiIrishCoffee);
            VendiIrishCoffee = new Cond.Whiskey(VendiIrishCoffee);
            VendiIrishCoffee = new Cond.Whip(VendiIrishCoffee);
            PrintBeverage(VendiIrishCoffee);

        }



        static void PrintBeverage(Bev.Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }
}