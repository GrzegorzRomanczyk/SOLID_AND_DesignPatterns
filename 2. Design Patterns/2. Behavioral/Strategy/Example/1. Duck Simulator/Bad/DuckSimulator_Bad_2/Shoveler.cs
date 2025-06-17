using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator_Bad_2
{
    public class Shoveler : Duck, IFlying, IQuacking
    {
        public override void Display()
        {
            System.Console.WriteLine("Jestem kaczka plaskonos");
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
