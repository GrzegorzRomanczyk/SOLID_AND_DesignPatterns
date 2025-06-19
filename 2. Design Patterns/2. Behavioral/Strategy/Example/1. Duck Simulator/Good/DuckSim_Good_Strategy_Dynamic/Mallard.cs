using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSim_Good_Strategy_Dynamic
{
    public class Mallard : Duck
    {
        public Mallard(IFlying flying, IQuacking quacking) : base(flying, quacking) { }


        public override void Display()
        {
            System.Console.WriteLine("Jestem kaczka krzyzowka");
        }
    }
}
