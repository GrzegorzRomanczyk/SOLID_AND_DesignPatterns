using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema_BaseCode
{
    public class PopcornMachine
    {
        private readonly string description;

        public PopcornMachine(string description)
        {
            this.description = description;
        }

        public void On()
        {
            Console.WriteLine($"{description} : włączona");
        }

        public void Off()
        {
            Console.WriteLine($"{description} : wyłączona");
        }

        public void PreparePopcorn()
        {
            Console.WriteLine($"{description} : przygotowuje popcorn!");
        }
    }
}
