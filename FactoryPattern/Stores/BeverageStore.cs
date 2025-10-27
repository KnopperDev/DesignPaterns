using System;
using FactoryPattern.Interfaces.Factories;
using FactoryPattern.Beverages;

namespace FactoryPattern.Stores
{
    internal class BeverageStore : Store
    {
        public BeverageStore(Factory factory) : base(factory)
        {
        }

        public override Beverage OrderBeverage(string type, string size = "")
        {
            Beverage beverage = _factory.CreateBeverage(type);
            beverage.SetSize(size);

            Console.WriteLine(beverage.GetDescription() + " €" +  beverage.cost().ToString("#.##"));

            return beverage;
        }
    }
}