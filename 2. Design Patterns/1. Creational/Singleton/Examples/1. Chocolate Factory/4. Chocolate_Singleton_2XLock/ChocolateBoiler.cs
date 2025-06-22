using System;

namespace _4.Chocolate_Singleton_2XLock
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private static ChocolateBoiler instance;

        private static readonly object _lock = new object();

        public static ChocolateBoiler Instance => instance;

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (instance == null) // 1. szybkie sprawdzenie
            {
                lock (_lock)       // 2. sekcja krytyczna
                {
                    if (instance == null) // 3. sprawdzenie jeszcze raz
                    {
                        instance = new ChocolateBoiler();
                    }
                }
            }
            return instance;
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