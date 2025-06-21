using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Good_SimpleFactory
{
    public class PizzaSimpleFactory
    {
        public Pizza Create(string type)
        {
            if (type.Equals("serowa"))
            {
                return new CheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                return new PepperoniPizza();
            }
            else if (type.Equals("wege"))
            {
                return new VegetarianPizza();
            }
            else if (type.Equals("owoce morza"))
            {
                return new SeafoodPizza();
            }
            return new MargheritaPizza();
        }
    }
}
