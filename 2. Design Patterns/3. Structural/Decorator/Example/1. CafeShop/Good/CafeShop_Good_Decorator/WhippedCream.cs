using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop_Good_Decorator
{
    public class WhippedCream : IngredientDecorator 
    {
        public WhippedCream(Drink baseDrink) : base(baseDrink) { }

        public override string GetDescription()
        {
            return baseDrink.GetDescription() + ", bita smietana";
        }

        public override decimal GetCost()
        {
            return baseDrink.GetCost() + 3.00m;
        }
    }
}
