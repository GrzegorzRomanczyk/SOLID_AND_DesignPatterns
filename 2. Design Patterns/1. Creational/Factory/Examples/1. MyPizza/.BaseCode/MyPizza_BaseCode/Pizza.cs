using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_BaseCode
{
    public abstract class Pizza
    {
        public void Prepare()
        {
            Console.WriteLine("przygotowywanie ciasta, nakladanie skladnikow itd");
        }

        public void Bake()
        {
            Console.WriteLine("pieczenie pizzy");
        }

        public void Cut()
        {
            Console.WriteLine("krojenie pizzy");
        }

        public void Pack()
        {
            Console.WriteLine("pakowanie pizzy");
        }
    }
}
