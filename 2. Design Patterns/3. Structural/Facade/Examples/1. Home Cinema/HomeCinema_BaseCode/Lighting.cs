using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema_BaseCode
{
    public class Lighting
    {
        private readonly string description;

        public Lighting(string description)
        {
            this.description = description;
        }

        public void On()
        {
            Console.WriteLine($"{description} : włączony");
        }

        public void Off()
        {
            Console.WriteLine($"{description} : wyłączony");
        }

        public void Dim(int level)
        {
            Console.WriteLine($"{description} : przyciemniono do poziomu {level}");
        }

        public override string ToString() => description;
    }
}
