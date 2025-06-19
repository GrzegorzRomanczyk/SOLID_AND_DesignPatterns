using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSim_Good_Strategy_Dynamic
{
    public class RubberDuck : Duck
    {
        public RubberDuck(IFlying flying, IQuacking quacking) : base(flying, quacking) { }

        public override void Display()
        {
            Console.WriteLine("To jest gumowa kaczka");
        }
    }
}
