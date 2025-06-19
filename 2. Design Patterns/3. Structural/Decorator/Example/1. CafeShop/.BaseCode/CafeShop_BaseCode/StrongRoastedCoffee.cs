using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop_BaseCode
{
    class StrongRoastedCoffee : Drink
    {
        public StrongRoastedCoffee()
        {
            description = "Kawa mocno palona";
        }

        public override decimal GetCost()
        {
            return 9.00M;
        }
    }
}
