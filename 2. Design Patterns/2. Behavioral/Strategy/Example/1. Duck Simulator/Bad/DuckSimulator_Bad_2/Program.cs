using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator_Bad_2
{
    public class Program
    {
        static void Main(string[] args)
        {

            var mallardDuck = new Mallard();
            mallardDuck.Display();
            mallardDuck.Quack();
            mallardDuck.Swim();
            mallardDuck.Fly();

            Console.WriteLine("\n");

            var shovelerDuck = new Shoveler();
            shovelerDuck.Display();
            shovelerDuck.Quack();
            shovelerDuck.Swim();
            shovelerDuck.Fly();

            Console.WriteLine("\n");

            var rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.Quack();
            rubberDuck.Swim();
            rubberDuck.Fly();

            Console.WriteLine("\n");

            var decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.Swim();

            Console.ReadKey();
        }
    }
}
