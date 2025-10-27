using FactoryPattern.Interfaces.Factories;
using FactoryPattern.Beverages;

namespace FactoryPattern.Stores
{
    internal abstract class Store
    {
        protected readonly Factory _factory;

        protected Store(Factory factory)
        {
            _factory = factory;
        }

        public abstract Beverage OrderBeverage(string type, string size = "");
    }
}