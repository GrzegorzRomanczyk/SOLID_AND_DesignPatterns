using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Bad
{
    public class PizzaService
    {
        public Pizza Order(string type)
        {
            Pizza pizza;
            if (type.Equals("serowa"))
            {
                pizza = new CheesePizza();
            }
            // usuwamy pizze z menu
            //else if (type.Equals("grecka"))
            //{
            //    pizza = new GreekPizza();
            //}
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals("wege"))
            {
                pizza = new VegetarianPizza();
            }
            else if (type.Equals("owoce morza"))
            {
                pizza = new SeafoodPizza();
            }
            else
            {
                pizza = new MargheritaPizza();
            }
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Pack();
            return pizza;
        }
    }
}
