using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator_Bad_2
{
    public abstract class Duck
    {
        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("<< kaczka plynie >>");
        }
    }
}
