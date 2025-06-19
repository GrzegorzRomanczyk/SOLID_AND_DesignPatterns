using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop_Good_Decorator
{
    public class Chocolate : IngredientDecorator
    {
        public Chocolate(Drink baseDrink) : base(baseDrink) {}

        public override string GetDescription()
        {
            return baseDrink.GetDescription() + ", czekolada";
        }

        public override decimal GetCost()
        {
            return baseDrink.GetCost() + 2.00m;
        }
    }
}
