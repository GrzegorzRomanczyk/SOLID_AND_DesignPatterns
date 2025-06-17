using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator_Bad_2
{
    // nowa kaczka dodana w wymaganiu 1 przykladu Bad_2
    class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Kaczka wabik");
        }
    }
}
