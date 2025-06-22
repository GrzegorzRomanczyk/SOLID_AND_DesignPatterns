using System;

namespace _5.Chocolate_Singleton_Lazzy
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private static readonly Lazy<ChocolateBoiler> instance = new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetInstance() => instance.Value;

        public void Fill()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Napelniam zbiornik");
                empty = false;
                boiled = false;
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                Console.WriteLine("Oprozniam zbiornik");
                empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                Console.WriteLine("Gotuje zawartosc kotla");
                boiled = true;
            }
        }

        private bool IsBoiled() => boiled;

        private bool IsEmpty() => empty;
    }
}