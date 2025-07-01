using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema_BaseCode
{
    public class Screen
    {
        private readonly string description;

        public Screen(string description)
        {
            this.description = description;
        }

        public void Up()
        {
            Console.WriteLine($"{description} : podniesiony");
        }

        public void Down()
        {
            Console.WriteLine($"{description} : opuszczony");
        }

        public override string ToString() => description;
    }
}
