using SuperPilot_Command_2.Commands.Abstractions;
using SuperPilot_Command_2.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPilot_Command_2.Commands
{
    class GarageDoorCloseCommand : ICommand
    {
        private readonly GarageDoor garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute() => garageDoor.Close();
    }
}
