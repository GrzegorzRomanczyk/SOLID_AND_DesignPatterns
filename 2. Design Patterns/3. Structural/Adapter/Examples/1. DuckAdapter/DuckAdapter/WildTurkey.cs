using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckAdapter
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Latam ale tylko na krotki dystans");
        }

        public void Gurgles()
        {
            Console.WriteLine("Gul, gul, gul");
        }
    }
}
