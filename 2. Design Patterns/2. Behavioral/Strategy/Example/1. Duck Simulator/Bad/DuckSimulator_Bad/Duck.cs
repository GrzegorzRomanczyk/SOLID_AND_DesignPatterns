using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator_Bad
{
    public abstract class Duck
    {
        //BaseCode
        //public void Quack()
        //{
        //    Console.WriteLine("Kwa, kwa");
        //}

        // Wymaganie 2 - przeslaniecie metody aby gumowa kaczka wydawala inny dzwiek
        public virtual void Quack()
        {
            Console.WriteLine("Kwa, kwa");
        }

        public void Swim()
        {
            Console.WriteLine("<< kaczka plynie >>");
        }

        // Wymaganie 1 rozszerzajace BaseCode
        //public void Fly()
        //{
        //    Console.WriteLine("<< kaczka leci >>");
        //}

        // Wymaganie 2 - przeslaniecie metody aby gumowa kaczka nie latala
        public virtual void Fly()
        {
            Console.WriteLine("<< kaczka leci >>");
        }

        public abstract void Display();
    }
}
