using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop_Good_Decorator
{
    public class DecaffeinatedCoffee : Drink
    {
        public DecaffeinatedCoffee()
        {
            description = "Kawa bezkofeinowa";
        }

        public override decimal GetCost()
        {
            return 8.00M;
        }
    }
}
