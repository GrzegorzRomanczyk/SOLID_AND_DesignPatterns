using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRecipesTemplateMethod
{
    public class CoffeService : DrinkService
    {
        protected override void AddToppings()
        {
            Console.WriteLine("Dodawanie cukru oraz mleka");
        }

        protected override void BrewDrink()
        {
            Console.WriteLine("Zalewanie kawy");
        }
    }
}
