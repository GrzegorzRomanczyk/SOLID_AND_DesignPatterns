using System;

namespace SuperPilot_Command.Devices
{
    public class Light
    {
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
