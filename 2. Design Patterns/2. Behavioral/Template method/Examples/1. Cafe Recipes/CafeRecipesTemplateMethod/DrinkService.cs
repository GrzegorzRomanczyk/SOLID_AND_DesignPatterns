using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRecipesTemplateMethod
{
    public abstract class DrinkService
    {
        public void PrepareDrink()
        {
            BoilWater();
            BrewDrink();
            PourCup();
            AddToppings();
            Console.ReadKey();
        }

        protected abstract void AddToppings();
        protected abstract void BrewDrink();

        private void PourCup()
        {
            Console.WriteLine("Nalewanie do filizanki");
        }

        private void BoilWater()
        {
            Console.WriteLine("Gotowanie wody");
        }
    }
}
