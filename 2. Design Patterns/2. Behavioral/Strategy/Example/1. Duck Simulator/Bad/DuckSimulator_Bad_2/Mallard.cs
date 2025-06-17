using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator_Bad_2
{
    public class Mallard : Duck, IFlying, IQuacking
    {
        public override void Display()
        {
            System.Console.WriteLine("Jestem kaczka krzyzowka");
        }

        public void Fly()
        {
            Console.WriteLine("<< kaczka leci >>");
        }

        public void Quack()
        {
            Console.WriteLine("Kwa, kwa");
        }
    }
}
