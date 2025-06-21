using MyPizza_Good_AbstractFactory.Factory;
using MyPizza_Good_AbstractFactory.PizzaType.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Good_AbstractFactory.PizzaType
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientsFactory pizzaIngredientsFactory;

        public CheesePizza(IPizzaIngredientsFactory pizzaIngredientsFactory)
        {
            this.pizzaIngredientsFactory = pizzaIngredientsFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Przygotowanie pizzy: " + name);
            dough = pizzaIngredientsFactory.CreateDough();
            dip = pizzaIngredientsFactory.CreateDip();
            cheese = pizzaIngredientsFactory.CreateCheese();
            vegetables = pizzaIngredientsFactory.CreateVegetables();
        }
    }
}
