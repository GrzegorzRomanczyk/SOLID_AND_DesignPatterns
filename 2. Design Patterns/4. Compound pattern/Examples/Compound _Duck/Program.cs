using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound__Duck
{
    public class Program
    {
        static void Main(string[] args)
        {
            var duckFactoryWithQuackCounter = new DuckFactoryWithQuackCounter();
            Run(duckFactoryWithQuackCounter);
        }

        private static void Run(DuckFactoryWithQuackCounter factory)
        {

            var mallardDuck = factory.CreateMallardDuck();
            var shovelerDuck = factory.CreateShovelerDuck();
            var decoyDuck = factory.CreateDecoyDuck();
            var rubberDuck = factory.CreateRubberDuck();
            var gooseAsDuck = new GooseAdapter(new Goose());

            Console.WriteLine("Symulator kaczek");

            var duckFlock = new Flock();
            duckFlock.AddToFlock(mallardDuck);
            duckFlock.AddToFlock(shovelerDuck);
            duckFlock.AddToFlock(decoyDuck);
            duckFlock.AddToFlock(rubberDuck);
            duckFlock.AddToFlock(gooseAsDuck);


            var mallardDuckFlock = new Flock();

            var mallardDuck1 = factory.CreateMallardDuck();
            var mallardDuck2 = factory.CreateMallardDuck();
            var mallardDuck3 = factory.CreateMallardDuck();
            var mallardDuck4 = factory.CreateMallardDuck();

            mallardDuckFlock.AddToFlock(mallardDuck1);
            mallardDuckFlock.AddToFlock(mallardDuck2);
            mallardDuckFlock.AddToFlock(mallardDuck3);
            mallardDuckFlock.AddToFlock(mallardDuck4);

            duckFlock.AddToFlock(mallardDuckFlock);

            Console.WriteLine("Symulacja calego stada");

            var quackologist = new Quackologist();
            duckFlock.Subscribe(quackologist);

            Run(duckFlock);

            Console.WriteLine("Symulacja stada kaczek krzyzowek");

            Run(mallardDuckFlock);


            Console.WriteLine($"Kaczki zakwakaly w sumie: {QuackCounterDecorator.QuackCount} razy");

            Console.ReadLine();
        }

        private static void Run(IQuack duck)
        {
            duck.Quack();
        }
    }
}
