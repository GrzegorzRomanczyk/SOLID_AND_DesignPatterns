using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuFusion_BaseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderService = new OrderService();
            Console.WriteLine("----------Wyswietlam cale menu-------------");
            orderService.DisplayMenu();
            Console.WriteLine();

            Console.WriteLine("----------Wyswietlam sniadaniowe menu-------------");
            orderService.DisplayBreakfastMenu();
            Console.WriteLine();

            Console.WriteLine("----------Wyswietlam obiadowe menu-------------");
            orderService.DisplayLunchMenu();
            Console.ReadKey();

        }
    }
}
