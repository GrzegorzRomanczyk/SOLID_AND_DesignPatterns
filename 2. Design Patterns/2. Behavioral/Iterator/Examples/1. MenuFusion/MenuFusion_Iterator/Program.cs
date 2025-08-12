using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuFusion_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var breakfastMenu = new BreakfastMenu();
            var lunchMenu = new LunchMenu();
            var orderService = new OrderService(breakfastMenu, lunchMenu);
            orderService.DisplayMenu();
            Console.Read();
        }
    }
}
