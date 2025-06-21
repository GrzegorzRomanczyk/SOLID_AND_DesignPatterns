using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Good_FactoryMethod.Product.American
{
    public class AmericanCheesePizza : Pizza
    {
        public AmericanCheesePizza()
        {
            name = "Amerykanska pizza serowa";
            dough = "Grube chrupkie ciasto";
            dip = "Sos z pomidorow sliwkowych";
            additions.Add("Grubo tarty ser mozzarella");
        }

        // pizza ma zmieniony sposob krojenia
        public override void Cut()
        {
            Console.WriteLine("Krojenie pizzy na kwadratowe kawalki");
        }
    }
}
