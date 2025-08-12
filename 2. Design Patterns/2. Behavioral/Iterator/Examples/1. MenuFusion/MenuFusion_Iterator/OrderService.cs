using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuFusion_Iterator
{
    public class OrderService
    {
        private readonly BreakfastMenu breakfastMenu;
        private readonly LunchMenu lunchMenu;

        public OrderService(BreakfastMenu breakfastMenu, LunchMenu lunchMenu)
        {
            this.breakfastMenu = breakfastMenu;
            this.lunchMenu = lunchMenu;
        }

        public void DisplayMenu()
        {
            Iterator breakfastIterator = breakfastMenu.CreateIterator();
            Iterator lunchMenuIterator = lunchMenu.CreateIterator();

            Console.WriteLine("-----Menu sniadaniowe-----");
            DisplayMenu(breakfastIterator);
            Console.WriteLine("");
            Console.WriteLine("-----Menu obiadowe-----");
            DisplayMenu(lunchMenuIterator);
        }

        private void DisplayMenu(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                Dish dish = iterator.Next();
                Console.WriteLine($"{dish.Name}, {dish.Description}, {dish.Price}");
            }
        }
    }
}
