using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Espresso : Beverage
    {
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
                    sizeCost = 0;
                    break;
                case Size.GRANDE:
                    sizeCost = 0.50;
                    break;
                case Size.VENDI:
                    sizeCost = 1.00;
                    break;
            }

            if (baseBeverage != null)
            {
                return 1.99 + baseBeverage.cost();
            }
            return 1.99;
        }
    }
}
