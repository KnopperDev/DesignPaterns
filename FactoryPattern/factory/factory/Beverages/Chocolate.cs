using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class CHocolate : Beverage
    {
        public CHocolate(Beverage beverage = null)
        {
            description = "CHocolate";
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
            if (baseBeverage != null)
            {
                return 3.99 + baseBeverage.cost();
            }
            return 3.99;
        }
    }
}
