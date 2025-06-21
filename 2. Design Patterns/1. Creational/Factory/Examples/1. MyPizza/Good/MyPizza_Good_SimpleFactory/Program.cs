using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Good_SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaSimpleFactory = new PizzaSimpleFactory();
            var pizzaService = new PizzaService(pizzaSimpleFactory);
            var orderedPizza = pizzaService.Order("pepperoni");
            Console.WriteLine("Zamowiona pizza to: " + orderedPizza.GetType().Name);

            Console.ReadKey();
        }
    }
}
