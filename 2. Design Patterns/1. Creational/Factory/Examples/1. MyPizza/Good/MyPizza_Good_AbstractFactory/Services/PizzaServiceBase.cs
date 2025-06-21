using MyPizza_Good_AbstractFactory.PizzaType.Abstract;

namespace MyPizza_Good_AbstractFactory.Services
{
    public abstract class PizzaServiceBase
    {
        public Pizza Order(string type)
        {
            Pizza pizza = Create(type);
            System.Console.WriteLine("--- Robię pizzę: " + pizza.GetName() + " ---");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Pack();

            return pizza;
        }

        protected abstract Pizza Create(string type);
    }
}
