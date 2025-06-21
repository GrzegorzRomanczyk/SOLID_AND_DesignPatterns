using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Good_FactoryMethod.Product.Italian
{
    public class ItalianCheesePizza : Pizza
    {
        public ItalianCheesePizza()
        {
            name = "Włoska pizza serowa z sosem marinara";
            dough = "Cienkie kruche ciasto";
            dip = "Sos marinara";
            additions.Add("Tarty ser reggiano");
        }
    }
}
