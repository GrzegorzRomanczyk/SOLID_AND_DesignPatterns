using MyPizza_Good_FactoryMethod.Factory;
using MyPizza_Good_FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Good_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaServiceBase italianPizzaFactory = new ItalianPizzaFactory();
            PizzaServiceBase americanPizzaFactory = new AmericanPizzaFactory();

            Pizza italianPizza = italianPizzaFactory.Order("serowa");
            Console.WriteLine($"Koniec zamowienia: - {italianPizza.GetName()}");

            Console.WriteLine("-------------------------------------------");

            Pizza americanPizza = americanPizzaFactory.Order("serowa");
            Console.WriteLine($"Koniec zamowienia: - {americanPizza.GetName()}");

            Console.ReadKey();
        }
    }
}
