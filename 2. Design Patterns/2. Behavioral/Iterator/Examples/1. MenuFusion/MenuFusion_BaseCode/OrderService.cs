using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuFusion_BaseCode
{
    public class OrderService
    {
        private ArrayList breakfastDishes;
        private Dish[] lunchDishes;

        public OrderService()
        {
            var breakfastMenu = new BreakfastMenu();
            breakfastDishes = breakfastMenu.GetDishes();

            var lunchMenu = new LunchMenu();
            lunchDishes = lunchMenu.GetDishes();
        }

        public void DisplayMenu()
        {
            DisplayBreakfastMenu();
            DisplayLunchMenu();
        }

        public void DisplayBreakfastMenu()
        {
            for (int i = 0; i < breakfastDishes.Count; i++)
            {
                Dish dish = (Dish)breakfastDishes[i];
                Console.WriteLine($"{dish.Name}, {dish.Description}, {dish.Price}");
            }
        }

        public void DisplayLunchMenu()
        {
            for (int i = 0; i < lunchDishes.Length; i++)
            {
                Dish dish = lunchDishes[i];
                Console.WriteLine($"{dish.Name}, {dish.Description}, {dish.Price}");
            }
        }
    }
}
