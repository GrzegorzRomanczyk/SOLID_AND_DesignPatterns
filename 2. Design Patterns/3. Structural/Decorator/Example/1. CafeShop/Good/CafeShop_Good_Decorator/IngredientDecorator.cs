using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop_Good_Decorator
{
    public abstract class IngredientDecorator : Drink
    {
        protected readonly Drink baseDrink;

        public IngredientDecorator(Drink baseDrink)
        {
            this.baseDrink = baseDrink;
        }
    }
}
