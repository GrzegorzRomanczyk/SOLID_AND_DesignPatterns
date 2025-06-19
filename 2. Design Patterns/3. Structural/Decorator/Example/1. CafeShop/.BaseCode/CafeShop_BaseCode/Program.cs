using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop_BaseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz kawe");
            Console.WriteLine("1. Espresso");
            Console.WriteLine("2. Kawa bezkofeinowa");
            Console.WriteLine("3. Kawa mocno palona");

            var selectedCoffe = GetDrink();
            var description = selectedCoffe.GetDescription();
            var cost = selectedCoffe.GetCost();
            Console.WriteLine($"Wybrana kawa to: {description} zl");
            Console.WriteLine($"Kawa koszuje {cost} zl");

            Console.ReadKey();
        }

        private static Drink GetDrink()
        {
            var selectedCoffe = Console.ReadKey(intercept: true);
            char keyChar = selectedCoffe.KeyChar;

            switch (keyChar)
            {
                case '1':
                    return new Espresso();
                case '2':
                    return new Espresso();
                case '3':
                    return new Espresso();

                default: 
                    return GetDrink();      
            }
        }
    }
}
