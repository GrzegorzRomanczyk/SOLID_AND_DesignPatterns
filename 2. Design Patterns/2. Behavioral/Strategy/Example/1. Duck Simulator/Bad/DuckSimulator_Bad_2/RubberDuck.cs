using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator_Bad_2
{
    public class RubberDuck : Duck, IQuacking
    {
        public override void Display()
        {
            Console.WriteLine("To jest gumowa kaczka");
        }

        public void Fly()
        {
            Console.WriteLine("Gumowa kaczka nie potrafi latac");
        }

        public void Quack()
        {
            Console.WriteLine("<< piszczy >>");
        }
    }
}
