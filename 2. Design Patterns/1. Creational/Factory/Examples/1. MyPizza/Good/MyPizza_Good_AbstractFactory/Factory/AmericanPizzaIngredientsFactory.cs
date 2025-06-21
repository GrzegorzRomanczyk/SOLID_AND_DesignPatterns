using MyPizza_Good_AbstractFactory.PizzaIngredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Good_AbstractFactory.Factory
{
    public class AmericanPizzaIngredientsFactory : IPizzaIngredientsFactory
    {
        public Cheese CreateCheese() => new MozzarellaCheese();

        public Dip CreateDip() => new TomatoDip();

        public Dough CreateDough() => new ThickCrustyDough();

        public Mussels CreateMussels() => new FreshMussels();

        public Pepperoni CreatePepperoni() => new SlicedPepperoni();

        public List<Vegetables> CreateVegetables()
        {
            return new List<Vegetables>()
            {
                new Mushrooms(),
                new RedPepper(),
                new BlackOlives(),
            };
        }
    }
}
