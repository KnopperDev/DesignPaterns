using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Beverages
{
    internal class Espresso : Beverage
    {
        private readonly Double price = 1.99;
        
        public Espresso(Beverage beverage = null)
        {
            description = "Espresso";
            this.baseBeverage = beverage;

        }
        public override string GetDescription()
        {
            if (baseBeverage != null)
            {
                return baseBeverage.GetDescription() + ", " + description;
            }
            return description;
        }
        public override double cost()
        {
            double sizeCost = 0;
            switch (Size)
            {
                case Size.TALL:
                    sizeCost = 0.50;
                    break;
                case Size.GRANDE:
                    sizeCost = 1.00;
                    break;
                case Size.VENDI:
                    sizeCost = 1.50;
                    break;
                default:
                    sizeCost = 1.00;
                    break;
            }

            if (baseBeverage != null)
            {
                return price + sizeCost + baseBeverage.cost();
            }
            return price + sizeCost;
        }
    }
}
