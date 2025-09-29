using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Factory
{
    internal static class BeverageFactory
    {
        public static Beverage CreateBeverage(BeverageType type)
        {
            switch (type)
            {
                case BeverageType.Espresso:
                    return new Beverages.Espresso();

                case BeverageType.Doppio:
                    return new Beverages.Espresso(new Beverages.Espresso());

                case BeverageType.Lungo:
                    return new Condiments.Water(new Beverages.Espresso());

                case BeverageType.Macchiato:
                    return new MilkFoam(new Beverages.Espresso());

                case BeverageType.Corretta:
                    return new Liqour(new Beverages.Espresso());

                case BeverageType.ConPanna:
                    return new Whip(new Beverages.Espresso());

                case BeverageType.Cappuccino:
                    return new MilkFoam(new SteamedMilk(new Beverages.Espresso()));

                case BeverageType.Americano:
                    return new Condiments.Water(new Condiments.Water(new Beverages.Espresso()));

                case BeverageType.CaffeLatte:
                    return new MilkFoam(
                        new SteamedMilk(
                            new SteamedMilk(
                                new Beverages.Espresso()
                            )
                        )
                    );

                case BeverageType.FlatWhite:
                    return new SteamedMilk(new SteamedMilk(new Beverages.Espresso()));

                case BeverageType.Romana:
                    return new Lemon(new Beverages.Espresso());

                case BeverageType.Morocchino:
                    return new MilkFoam(new Chocolate(new Beverages.Espresso()));

                case BeverageType.Mocha:
                    return new Whip(new SteamedMilk(new Chocolate(new Beverages.Espresso())));

                case BeverageType.Bicerin:
                    return new Whip(new WhiteChocolate(new BlackChocolate(new Beverages.Espresso())));

                case BeverageType.Breve:
                    return new HalfMilk(new MilkFoam(new Beverages.Espresso()));

                case BeverageType.RafCoffee:
                    return new Cream(new VanillaSugar(new Beverages.Espresso()));

                case BeverageType.MeadRaf:
                    return new Cream(new Honey(new Beverages.Espresso()));

                case BeverageType.Galao:
                    return new MilkFoam(new MilkFoam(new Beverages.Espresso()));

                case BeverageType.CaffeAffogato:
                    return new Icecream(new Beverages.Espresso(new Beverages.Espresso()));

                case BeverageType.ViennaCoffee:
                    return new Whip(new Whip(new Beverages.Espresso(new Beverages.Espresso())));

                case BeverageType.Glace:
                    return new Icecream(new Beverages.Espresso());

                case BeverageType.ChocolateMilk:
                    return new Milk(new Milk(new Chocolate()));

                case BeverageType.DemiCreme:
                    return new Cream(new Cream(new Beverages.Espresso(new Beverages.Espresso())));

                case BeverageType.LatteMacchiato:
                    return new MilkFoam(new SteamedMilk(new SteamedMilk(new Beverages.Espresso())));

                case BeverageType.Freddo:
                    return new Ice(new Liqour(new Beverages.Espresso()));

                case BeverageType.Frappuccino:
                    return new Whip(new SteamedMilk(new Ice(new Beverages.Espresso())));

                case BeverageType.CaramelFrappuccino:
                    return new Syrup(new Cream(new SteamedMilk(new Ice(new Beverages.Espresso()))));

                case BeverageType.Frappe:
                    return new Icecream(new SteamedMilk(new SteamedMilk(new Beverages.Espresso())));

                case BeverageType.IrishCoffee:
                    return new Whip(new Whiskey(new Beverages.Espresso(new Beverages.Espresso())));

                default:
                    throw new ArgumentException("Unknown beverage type.");
            }
        }
    }
}
