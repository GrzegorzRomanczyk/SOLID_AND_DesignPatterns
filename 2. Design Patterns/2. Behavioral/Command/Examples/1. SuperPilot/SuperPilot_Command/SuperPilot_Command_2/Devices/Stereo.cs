using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPilot_Command_2.Devices
{
    public class Stereo
    {
        public void TurnOn()
        {
            Console.WriteLine("Wieza stereo zostala wlaczonona");
        }

        public void TurnOff()
        {
            Console.WriteLine("Wieza stereo zostala wylaczona");
        }

        public void SetCd()
        {
            Console.WriteLine("Ustawiono CD");
        }
        public void SetDvd()
        {
            Console.WriteLine("Ustawiono DVD");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Ustawiono głośnośc na {volume}");
        }
    }
}
