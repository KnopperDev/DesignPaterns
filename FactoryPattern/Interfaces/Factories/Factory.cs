
namespace FactoryPattern.Interfaces.Factories
{
    using FactoryPattern.Beverages;
    
    internal abstract class Factory
    {
        public abstract Beverage CreateBeverage(string type);
    }
}