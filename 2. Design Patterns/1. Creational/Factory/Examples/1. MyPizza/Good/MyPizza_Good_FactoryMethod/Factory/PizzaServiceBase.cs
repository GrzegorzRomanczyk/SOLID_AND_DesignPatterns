using MyPizza_Good_FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Good_FactoryMethod.Factory
{
    public abstract class PizzaServiceBase
    {
        public Pizza Order(string type)
        {
            Pizza pizza = Create(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Pack();

            return pizza;
        }

        protected abstract Pizza Create(string type);
    }
}
