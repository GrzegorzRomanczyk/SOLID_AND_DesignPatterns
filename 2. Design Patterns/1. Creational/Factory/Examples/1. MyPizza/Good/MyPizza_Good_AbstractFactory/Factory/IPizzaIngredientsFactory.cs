using MyPizza_Good_AbstractFactory.PizzaIngredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Good_AbstractFactory.Factory
{
    public interface IPizzaIngredientsFactory
    {
        Dough CreateDough();
        Dip CreateDip();
        Cheese CreateCheese();
        Pepperoni CreatePepperoni();
        List<Vegetables> CreateVegetables();
        Mussels CreateMussels();
    }
}
