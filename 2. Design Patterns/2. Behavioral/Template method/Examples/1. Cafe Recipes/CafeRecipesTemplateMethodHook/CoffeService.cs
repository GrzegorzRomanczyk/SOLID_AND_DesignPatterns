using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRecipesTemplateMethodHook
{
    public class CoffeService : DrinkService
    {
        protected override void AddToppings()
        {
            Console.WriteLine("Dodawanie cukru oraz mleka");
        }

        protected override void BrewDrink()
        {
            Console.WriteLine("Zalewanie kawy");
        }

        protected override bool WithToppings()
        {
            string answer = GetUserAnswer();
            if (answer.ToLower().StartsWith("t"))
            {
                return true;
            }
            return false;
        }

        private string GetUserAnswer()
        {
            Console.WriteLine("Dodac cukier i mleko? (t/n)");
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            if (keyInfo.Key == ConsoleKey.T)
            {
                return "t";
            }
            return "n";
        }
    }
}
