using System;

namespace _1.Chocolate_Singleton
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        public ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

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