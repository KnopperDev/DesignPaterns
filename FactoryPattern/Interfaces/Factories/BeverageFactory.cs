namespace FactoryPattern.Interfaces.Factories
{
    using Bev = FactoryPattern.Beverages;
    using Con = FactoryPattern.Condiments;

    internal class BeverageFactory : Factory
    {
        public override Bev::Beverage CreateBeverage(string type)
        {
            Bev::Beverage beverage = null;

            type = type.Replace(" ", "").Replace("_", "").ToLower();

            switch (type)
            {
                case "espresso":
                    beverage = new Bev::Espresso();
                    break;
                case "doppio":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Espresso(beverage);
                    break;
                case "lungo":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Water(beverage);
                    break;
                case "macchiato":
                    beverage = new Bev::Espresso();
                    beverage = new Con::MilkFoam(beverage);
                    break;
                case "corretta":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Liqour(beverage);
                    break;
                case "conpanna":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Whip(beverage);
                    break;
                case "cappucinno":
                    beverage = new Bev::Espresso();
                    beverage = new Con::SteamedMilk(beverage);
                    beverage = new Con::MilkFoam(beverage);
                    break;
                case "americano":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Water(beverage);
                    beverage = new Con::Water(beverage);
                    break;
                case "caffélatte":
                    beverage = new Bev::Espresso();
                    beverage = new Con::SteamedMilk(beverage);
                    beverage = new Con::SteamedMilk(beverage);
                    beverage = new Con::MilkFoam(beverage);
                    break;
                case "flatwhite":
                    beverage = new Bev::Espresso();
                    beverage = new Con::SteamedMilk(beverage);
                    beverage = new Con::SteamedMilk(beverage);
                    break;
                case "romana":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Lemon(beverage);
                    break;
                case "morocchino":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Chocolate(beverage);
                    beverage = new Con::MilkFoam(beverage);
                    break;
                case "mocha":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Chocolate(beverage);
                    beverage = new Con::SteamedMilk(beverage);
                    beverage = new Con::Whip(beverage);
                    break;
                case "bicerin":
                    beverage = new Bev::Espresso();
                    beverage = new Con::BlackChocolate(beverage);
                    beverage = new Con::WhiteChocolate(beverage);
                    beverage = new Con::Whip(beverage);
                    break;
                case "breve":
                    beverage = new Bev::Espresso();
                    beverage = new Con::MilkFoam(beverage);
                    beverage = new Con::HalfMilk(beverage);
                    break;
                case "rafcoffee":
                    beverage = new Bev::Espresso();
                    beverage = new Con::VanillaSugar(beverage);
                    beverage = new Con::Cream(beverage);
                    break;
                case "meadraf":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Honey(beverage);
                    beverage = new Con::Cream(beverage);
                    break;
                case "galao":
                    beverage = new Bev::Espresso();
                    beverage = new Con::MilkFoam(beverage);
                    beverage = new Con::MilkFoam(beverage);
                    break;
                case "cafféaffogato":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Espresso(beverage);
                    beverage = new Con::IceCream(beverage);
                    break;
                case "viennacoffee":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Espresso(beverage);
                    beverage = new Con::Whip(beverage);
                    beverage = new Con::Whip(beverage);
                    break;
                case "glace":
                    beverage = new Bev::Espresso();
                    beverage = new Con::IceCream(beverage);
                    break;
                case "chocolatemilk":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Milk(beverage);
                    beverage = new Con::Milk(beverage);
                    break;
                case "demicreme":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Espresso(beverage);
                    beverage = new Con::Cream(beverage);
                    beverage = new Con::Cream(beverage);
                    break;
                case "lattemacchiato":
                    beverage = new Bev::Espresso();
                    beverage = new Con::SteamedMilk(beverage);
                    beverage = new Con::SteamedMilk(beverage);
                    beverage = new Con::MilkFoam(beverage);
                    break;
                case "freddo":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Liqour(beverage);
                    beverage = new Con::Ice(beverage);
                    break;
                case "frappuccino":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Ice(beverage);
                    beverage = new Con::SteamedMilk(beverage);
                    beverage = new Con::Whip(beverage);
                    break;
                case "caramelfrappuccino":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Ice(beverage);
                    beverage = new Con::SteamedMilk(beverage);
                    beverage = new Con::Cream(beverage);
                    beverage = new Con::Syrup(beverage);
                    break;
                case "frappe":
                    beverage = new Bev::Espresso();
                    beverage = new Con::SteamedMilk(beverage);
                    beverage = new Con::SteamedMilk(beverage);
                    beverage = new Con::IceCream(beverage);
                    break;
                case "irishcoffee":
                    beverage = new Bev::Espresso();
                    beverage = new Con::Espresso(beverage);
                    beverage = new Con::Whiskey(beverage);
                    beverage = new Con::Whip(beverage);
                    break;
                default:
                    Console.WriteLine("Invalid beverage type: " + type);
                    break;
            }

            return beverage;
        }
    }
}