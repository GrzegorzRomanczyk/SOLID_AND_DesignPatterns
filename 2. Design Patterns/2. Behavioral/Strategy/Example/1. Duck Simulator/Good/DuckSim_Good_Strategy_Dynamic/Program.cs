using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSim_Good_Strategy_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallardDuck = new Mallard(new FlyOnWings(), new Quacking());
            mallardDuck.Display();
            mallardDuck.ExecuteQuack();
            mallardDuck.Swim();
            mallardDuck.ExecuteFly();

            Console.WriteLine("\n");

            var shovelerDuck = new Shoveler(new FlyOnWings(), new Quacking());
            shovelerDuck.Display();
            shovelerDuck.ExecuteQuack();
            shovelerDuck.Swim();
            shovelerDuck.ExecuteFly();

            Console.WriteLine("\n");

            var rubberDuck = new RubberDuck(new CantFly(), new Squeaks());
            rubberDuck.Display();
            rubberDuck.ExecuteQuack();
            rubberDuck.Swim();
            rubberDuck.ExecuteFly();

            Console.WriteLine("\n");

            var decoyDuck = new DecoyDuck(new CantFly(), new CantQuack());
            decoyDuck.Display();
            decoyDuck.ExecuteQuack();
            decoyDuck.Swim();
            decoyDuck.ExecuteFly();

            Console.WriteLine("Teraz zmienie zachowanie!!");
            decoyDuck.SetFlying(new FlyRocketEngine());
            decoyDuck.ExecuteFly();

            Console.ReadKey();
        }
    }
}
