using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSim_Good_Strategy_Dynamic
{
    class Quacking : IQuacking
    {
        public void Quack()
        {
            Console.WriteLine("Kwa, kwa");
        }
    }
}
