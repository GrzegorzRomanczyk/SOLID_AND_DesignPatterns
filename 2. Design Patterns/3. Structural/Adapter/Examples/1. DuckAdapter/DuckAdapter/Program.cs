using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var duck = new Mallard();
            var turkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("Zachowanie indyka");
            turkey.Gurgles();
            turkey.Fly();

            Console.WriteLine("\nZachowanie kaczki");
            duck.Quack();
            duck.Fly();

            Console.WriteLine("\nA teraz indyk udajacy kaczke");
            turkeyAdapter.Quack();
            turkeyAdapter.Fly();

            Console.ReadKey();
        }
    }
}
