using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop_Good_Decorator
{
    public class SoyaMilk : IngredientDecorator
    {
        public SoyaMilk(Drink baseDrink) : base(baseDrink) { }

        public override string GetDescription()
        {
            return baseDrink.GetDescription() + ", mleko sojowe";
        }

        public override decimal GetCost()
        {
            return baseDrink.GetCost() + 2.50m;
        }
    }
}
