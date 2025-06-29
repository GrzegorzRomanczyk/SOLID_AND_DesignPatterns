using SuperPilot_Command_2.Commands.Abstractions;
using SuperPilot_Command_2.Devices;

namespace SuperPilot_Command_2.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute() => garageDoor.Open();
    }
}
