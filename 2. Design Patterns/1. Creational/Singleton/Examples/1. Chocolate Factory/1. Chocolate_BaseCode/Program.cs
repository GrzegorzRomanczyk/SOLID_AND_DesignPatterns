using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Chocolate_BaseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var chocolateBoiler = new ChocolateBoiler();
            chocolateBoiler.Fill();
            chocolateBoiler.Boil();
            chocolateBoiler.Drain();

            Console.ReadKey();
        }
    }
}
