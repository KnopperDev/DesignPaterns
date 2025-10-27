using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Interfaces.Factories;

namespace FactoryPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }
    
    internal abstract class Beverage
    {
        public Size Size { get { return size; } set { size = value; } }
        private Size size;

        protected string description = "Unknown";
        protected Beverage baseBeverage = null;


        public virtual string GetDescription()
        {
            return description;
        }

        public void SetSize(string size)
        {
            switch (size.ToLower())
            {
                case "tall":
                    this.size = Size.TALL;
                    break;
                case "grande":
                    this.size = Size.GRANDE;
                    break;
                case "vendi":
                    this.size = Size.VENDI;
                    break;
                default:
                    this.size = Size.GRANDE;
                    break;
            }
        }

        public abstract double cost();
    }
}
