using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator_Good_Strategy
{
    class DecoyDuck : Duck
    {
        public DecoyDuck(IFlying flying, IQuacking quacking) : base(flying, quacking) { }

        public override void Display()
        {
            Console.WriteLine("Kaczka wabik");
        }
    }
}
