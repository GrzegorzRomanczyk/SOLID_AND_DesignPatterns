using MyPizza_Good_FactoryMethod.Product;
using MyPizza_Good_FactoryMethod.Product.Italian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Good_FactoryMethod.Factory
{
    class ItalianPizzaFactory : PizzaServiceBase
    {
        protected override Pizza Create(string type)
        {
            if (type.Equals("serowa"))
            {
                return new ItalianCheesePizza();
            }
            return null;
        }
    }
}
