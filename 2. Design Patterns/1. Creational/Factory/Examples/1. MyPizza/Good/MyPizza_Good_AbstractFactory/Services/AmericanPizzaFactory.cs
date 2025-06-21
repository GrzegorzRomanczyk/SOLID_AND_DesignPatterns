using MyPizza_Good_AbstractFactory.Factory;
using MyPizza_Good_AbstractFactory.PizzaType;
using MyPizza_Good_AbstractFactory.PizzaType.Abstract;

namespace MyPizza_Good_AbstractFactory.Services
{
    public class AmericanPizzaFactory : PizzaServiceBase
    {
        protected override Pizza Create(string type)
        {
            Pizza pizza = null;
            var pizzaIngredientsFactory = new AmericanPizzaIngredientsFactory();

            if (type.Equals("serowa"))
            {
                pizza = new CheesePizza(pizzaIngredientsFactory);
                pizza.SetName("Wloska pizza serowa");
            }
            else if (type.Equals("owoce morza"))
            {
                pizza = new SeafoodPizza(pizzaIngredientsFactory);
                pizza.SetName("Wloska pizza z owocami morza");
            }
            return pizza;
        }
    }
}
