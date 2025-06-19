using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop_Good_Decorator
{
    public class Milk : IngredientDecorator
    {
        public Milk(Drink baseDrink) : base(baseDrink) { }

        public override string GetDescription()
        {
            return baseDrink.GetDescription() + ", mleko";
        }

        public override decimal GetCost()
        {
            return baseDrink.GetCost() + 1.00m;
        }
    }
}
