using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator_BaseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallardDuck = new Mallard();
            mallardDuck.Display();
            mallardDuck.Quack();
            mallardDuck.Swim();

            Console.WriteLine("\n");

            var shovelerDuck = new Shoveler();
            shovelerDuck.Display();
            shovelerDuck.Quack();
            shovelerDuck.Swim();

            Console.ReadKey();
        }
    }
}
