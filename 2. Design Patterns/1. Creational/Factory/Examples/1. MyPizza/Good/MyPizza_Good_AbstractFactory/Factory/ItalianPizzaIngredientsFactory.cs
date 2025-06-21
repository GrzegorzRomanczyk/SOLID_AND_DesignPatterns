using MyPizza_Good_AbstractFactory.PizzaIngredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Good_AbstractFactory.Factory
{
    public class ItalianPizzaIngredientsFactory : IPizzaIngredientsFactory
    {
        public Cheese CreateCheese() => new ReggianoCheese();


        public Dip CreateDip() => new MarinaraDip();

        public Dough CreateDough() => new ThinCrispyDough();


        public Mussels CreateMussels() => new FreshMussels();



        public Pepperoni CreatePepperoni() => new SlicedPepperoni();

 
        public List<Vegetables> CreateVegetables()
        {
            return new List<Vegetables>()
            {
                new Garlic(),
                new Onion(),
                new Mushrooms(),
                new RedPepper()
            };
        }
 
    }
}
