using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop_Good_Decorator
{
    public class Espresso : Drink
    {
        public Espresso()
        {
            description = "Kawa espresso";
        }

        public override decimal GetCost()
        {
            return 10.00M;
        }
    }
}
