using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema_BaseCode
{
    public class Projector
    {
        private readonly string description;

        public Projector(string description)
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

        public void SetWidescreenMode()
        {
            Console.WriteLine($"{description} : wybrano tryb szerokoekranowy (16x9)");
        }

        public void SetTvMode()
        {
            Console.WriteLine($"{description} : włączono tryb telewizyjny (4x3)");
        }

        public override string ToString() => description;
    }
}
