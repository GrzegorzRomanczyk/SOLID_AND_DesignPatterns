using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRecipesTemplateMethodHook
{
    public class TeaService : DrinkService
    {
        protected override void AddToppings()
        {
            Console.WriteLine("Dodawanie cytryny");
        }

        protected override void BrewDrink()
        {
            Console.WriteLine("Zalewanie herbaty");
        }
    }
}
