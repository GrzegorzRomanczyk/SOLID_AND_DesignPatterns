using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop_Bad
{
    public abstract class Drink
    {
        protected string description;
        protected bool milk;
        protected bool soyaMilk;
        protected bool chocolate;
        protected bool whippedCream;

        public string GetDescription()
        {
            return description;
        }

        public bool WithMilk() => milk = true;
        public bool WithSoyaMilk() => soyaMilk = true;
        public bool WithChocolate() => chocolate = true;
        public bool WithWhippedCream() => whippedCream = true;

        private decimal AddMilkCost() => 2.00m;
        private decimal AddSoyaMilkCost() => 3.00m;
        private decimal AddChocolateCost() => 2.50m;
        private decimal AddWhippedCreamCost() => 1.50m;

        public virtual decimal GetCost()
        {
            decimal additionsCost = 0;
            if(milk)
            {
                additionsCost += AddMilkCost();
            }

            if (soyaMilk)
            {
                additionsCost += AddSoyaMilkCost();
            }

            if (chocolate)
            {
                additionsCost += AddChocolateCost();
            }

            if (whippedCream)
            {
                additionsCost += AddWhippedCreamCost();
            }
            return additionsCost;
        }
    }
}
