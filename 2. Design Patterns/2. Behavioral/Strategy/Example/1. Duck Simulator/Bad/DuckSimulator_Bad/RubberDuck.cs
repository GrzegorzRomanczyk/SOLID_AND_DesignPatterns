using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator_Bad
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("To jest gumowa kaczka");
        }

        public override void Fly()
        {
            Console.WriteLine("Gumowa kaczka nie potrafi latac");
        }

        public override void Quack()
        {
            Console.WriteLine("<< piszczy >>");
        }
    }
}
