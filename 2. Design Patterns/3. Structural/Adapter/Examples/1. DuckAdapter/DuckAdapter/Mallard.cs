using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckAdapter
{
    public class Mallard : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Ja latam!!");
        }

        public void Quack()
        {
            Console.WriteLine("Kwa, Kwa");
        }
    }
}
