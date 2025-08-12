using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuFusion_BaseCode
{
    public class LunchMenu
    {
        private const int MAX_DISHES = 3;
        private int dishesCounter = 0;
        private Dish[] dishes;

        public LunchMenu()
        {
            dishes = new Dish[MAX_DISHES];
            AddDish("Wege kanapka", "Kanapka z salata, pomidorem i innymi warzywami", true, 20.00m);
            AddDish("Hot dog", "Hot dog z parowka, prazona cebulka i sosami", false, 20.00m);
            AddDish("Zupa dnia", "W kazdy dzien inna zupa", false, 10.00m);
        }

        private void AddDish(string name, string description, bool isWege, decimal price)
        {
            var dish = new Dish(name, description, isWege, price);
            if (dishesCounter >= MAX_DISHES)
            {
                Console.WriteLine("Nie mozna dodac dania. Menu jest pelne");
            }
            else
            {
                dishes[dishesCounter] = dish;
                dishesCounter++;
            }

        }

        public Dish[] GetDishes() => dishes;
    }
}
