using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Bad
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaService = new PizzaService();
            var orderedPizza = pizzaService.Order("pepperoni");
            Console.WriteLine("Zamowiona pizza to: " + orderedPizza.GetType().Name);

            Console.ReadKey();
        }
    }
}
