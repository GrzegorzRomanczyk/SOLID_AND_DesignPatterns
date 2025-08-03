using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRecipesTemplateMethodHook
{
    public abstract class DrinkService
    {
        public void PrepareDrink()
        {
            BoilWater();
            BrewDrink();
            PourCup();
            if(WithToppings())
            {
                AddToppings();
            }
            Console.WriteLine("Napoj gotowy");
            Console.ReadKey();
        }

        protected virtual bool WithToppings() => true;

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
