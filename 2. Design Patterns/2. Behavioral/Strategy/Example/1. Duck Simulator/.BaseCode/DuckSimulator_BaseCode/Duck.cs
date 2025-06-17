using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator_BaseCode
{
    public abstract class Duck
    {
        public void Quack()
        {
            Console.WriteLine("Kwa, kwa");
        }

        public void Swim()
        {
            Console.WriteLine("<< swimming >>");
        }

        public abstract void Display();
    }
}
