using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShop_Good_Decorator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Wybierz kawe");
            Console.WriteLine("1. Espresso");
            Console.WriteLine("2. Kawa bezkofeinowa");
            Console.WriteLine("3. Kawa mocno palona");

            var selectedCoffe = GetDrink();

            Console.WriteLine("Dodac dodatki? T/N");
            var answer = Console.ReadKey(intercept: true);
            char keyChar = answer.KeyChar;
            if (keyChar == 't')
            {
                selectedCoffe = AddAddiotionals(selectedCoffe);
            }

            var description = selectedCoffe.GetDescription();
            var cost = selectedCoffe.GetCost();

            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Wybrana kawa to: {description} zl");
            Console.WriteLine($"Kawa koszuje {cost} zl");

            Console.ReadKey();
        }

        private static Drink AddAddiotionals(Drink baseSelectedDrink)
        {
            Console.WriteLine("Dodac mleko? T/N");
            var answer = Console.ReadKey(intercept: true);
            char keyChar = answer.KeyChar;
            if (keyChar == 't')
            {
                baseSelectedDrink = new Milk(baseSelectedDrink);
            }

            Console.WriteLine("Dodac mleko sojowe? T/N");
            answer = Console.ReadKey(intercept: true);
            keyChar = answer.KeyChar;
            if (keyChar == 't')
            {
                baseSelectedDrink = new SoyaMilk(baseSelectedDrink);
            }

            Console.WriteLine("Dodac czekolade? T/N");
            answer = Console.ReadKey(intercept: true);
            keyChar = answer.KeyChar;
            if (keyChar == 't')
            {
                baseSelectedDrink = new Chocolate(baseSelectedDrink);
            }

            Console.WriteLine("Dodac bita smietane? T/N");
            answer = Console.ReadKey(intercept: true);
            keyChar = answer.KeyChar;
            if (keyChar == 't')
            {
                baseSelectedDrink = new WhippedCream(baseSelectedDrink);
            }
            return baseSelectedDrink;
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
