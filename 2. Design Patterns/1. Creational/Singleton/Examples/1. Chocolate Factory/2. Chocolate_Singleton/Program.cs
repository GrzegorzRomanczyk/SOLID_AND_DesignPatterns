using System;

namespace _2.Chocolate_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var chocolateBoiler = ChocolateBoiler.GetInstance();
            chocolateBoiler.Fill();
            chocolateBoiler.Boil();
            chocolateBoiler.Drain();

            Console.ReadKey();
        }
    }
}
