using MyPizza_Good_AbstractFactory.PizzaType.Abstract;
using MyPizza_Good_AbstractFactory.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Good_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var italianpizzaService = new ItalianPizzaFactory();
            Pizza orderedPizza =  italianpizzaService.Order("serowa");
            Console.WriteLine(orderedPizza);

            Console.ReadKey();
        }
    }
}
