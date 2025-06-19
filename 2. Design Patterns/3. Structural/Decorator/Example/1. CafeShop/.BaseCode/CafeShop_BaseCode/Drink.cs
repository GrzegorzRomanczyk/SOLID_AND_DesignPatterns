using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop_BaseCode
{
    public abstract class Drink
    {
        protected string description;

        public string GetDescription()
        {
            return description;
        }

        public abstract decimal GetCost();
    }
}
