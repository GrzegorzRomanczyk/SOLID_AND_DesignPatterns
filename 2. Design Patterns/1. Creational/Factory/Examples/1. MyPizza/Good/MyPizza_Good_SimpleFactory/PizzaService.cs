using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Good_SimpleFactory
{
    public class PizzaService
    {
        private readonly PizzaSimpleFactory pizzaSimpleFactory;

        public PizzaService(PizzaSimpleFactory pizzaSimpleFactory)
        {
            this.pizzaSimpleFactory = pizzaSimpleFactory;
        }

        public Pizza Order(string type)
        {
            Pizza pizza = pizzaSimpleFactory.Create(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Pack();
            return pizza;
        }
    }
}
