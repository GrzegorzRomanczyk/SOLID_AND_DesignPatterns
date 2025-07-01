using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema_Facade
{
    public class CdPlayer
    {
        private readonly string description;
        private string name;
        private int currentTruck;
        private readonly Amplifier amplifier;

        public CdPlayer(string description, Amplifier amplifier)
        {
            this.description = description;
            this.amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine($"{description} : włączony");
        }

        public void Off()
        {
            Console.WriteLine($"{description} : wyłączony");
        }

        public void Eject()
        {
            name = null;
            Console.WriteLine($"{description} : wysuwanie plyty");
        }

        public void Play(string name)
        {
            this.name = name;
            currentTruck = 0;
            Console.WriteLine($"{description} : odtwarzaj utwór {this.name}");
        }

        public void Play(int currentTruck)
        {
            if (name == null)
            {
                Console.WriteLine($"{description} : nie może odtwarzać ścieżki {this.currentTruck}, nie włożono płyty.");
            }
            else
            {
                this.currentTruck = currentTruck;
                Console.WriteLine($"{description} : odtwarzaj utwór {this.currentTruck}");
            }
        }

        public void Stop()
        {
            currentTruck = 0;
            Console.WriteLine($"{description} : zatrzymany");
        }

        public void Pause()
        {
            Console.WriteLine($"{description} : wstrzymał odtwarzanie utworu {name}");
        }

        public override string ToString() => description;
    }
}
