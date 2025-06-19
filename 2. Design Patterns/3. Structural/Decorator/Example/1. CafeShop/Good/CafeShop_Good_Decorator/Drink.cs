using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop_Good_Decorator
{
    public abstract class Drink
    {
        protected string description;

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract decimal GetCost();
    }
}
