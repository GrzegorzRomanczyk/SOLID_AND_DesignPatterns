using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPilot_Command_2.Devices
{
    public class GarageDoor
    {
        public void Open()
        {
            Console.WriteLine("Drzwi sie otwieraja");
        }

        public void Close()
        {
            Console.WriteLine("Drzwi sie zamykaja");
        }

        public void Stop()
        {
            Console.WriteLine("Zatrzymano operacje otwierania/zamykania drzwi");
        }

        public void TurnOn()
        {
            Console.WriteLine("Swiatlo zostalo wlaczone");
        }

        public void TurnOff()
        {
            Console.WriteLine("Swiatlo zostalo wylaczone");
        }
    }
}
