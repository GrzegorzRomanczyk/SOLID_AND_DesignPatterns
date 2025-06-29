using SuperPilot_Command.Commands;
using SuperPilot_Command.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPilot_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var light = new Light();
            var lightOnCommand = new LightOnCommand(light);
            var miniPilot = new MiniPilot(lightOnCommand);

            miniPilot.ButtonPressed();

            Console.ReadKey();
            Console.Clear();

            var otherMiniPilot = new MiniPilot();
            var garageDoor = new GarageDoor();
            var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);

            otherMiniPilot.SetCommand(lightOnCommand);
            otherMiniPilot.ButtonPressed();

            Console.WriteLine("----- A teraz zmiana urzadzenia w gniezdzie -----");
            otherMiniPilot.SetCommand(garageDoorOpenCommand);
            otherMiniPilot.ButtonPressed();

            Console.ReadKey();
        }
    }
}
