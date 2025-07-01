using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema_BaseCode
{
    public class Tuner
    {
        private readonly string description;
        private Amplifier amplifier;
        private double frequency;

        public Tuner(string description, Amplifier amplifier)
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

        public void SetFrequency(double frequency)
        {
            Console.WriteLine($"{description} : ustaw czestotliwosc na {frequency}");
            this.frequency = frequency;
        }

        public void SetAm()
        {
            Console.WriteLine($"{description} : wlaczono tryb AM");
        }

        public void SetFm()
        {
            Console.WriteLine($"{description} : wlaczono tryb FM");
        }


        public override string ToString() => description;
    }
}
