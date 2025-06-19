using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator_Good_Strategy
{
    class CantQuack : IQuacking
    {
        public void Quack()
        {
            Console.WriteLine("Nie wydaje dzwieku");
        }
    }
}
