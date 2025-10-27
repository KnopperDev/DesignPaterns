using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Water : Beverage
    {
        public Water(Beverage beverage = null)
        {
            description = "Water";
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
                return 0.50 + baseBeverage.cost();
            }
            return 0.50;
        }
    }
}
