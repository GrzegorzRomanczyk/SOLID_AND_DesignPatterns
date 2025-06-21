using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_Good_FactoryMethod.Product
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string dip;
        protected List<string> additions = new List<string>();

        public string GetName() => name;

        public void Prepare()
        {
            Console.WriteLine($"Przygotowywanie pizzy: {name}");
            Console.WriteLine("Wyrabianie ciasta");
            Console.WriteLine("Dodawanie sosu");
            Console.WriteLine("Dodatki: ");
            foreach (string item in additions)
            {
                Console.WriteLine(item);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Pieczenie: 25 minut w temperaturze 180 stopni");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Krojenie pizzy na 8 kawalkow");
        }

        public void Pack()
        {
            Console.WriteLine("Pakowanie pizzy do kwadratowego pudelka");
        }
    }
}
