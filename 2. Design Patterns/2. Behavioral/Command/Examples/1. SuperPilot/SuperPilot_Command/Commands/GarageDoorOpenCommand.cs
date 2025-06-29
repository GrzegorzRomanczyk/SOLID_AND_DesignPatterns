using SuperPilot_Command.Commands.Abstractions;
using SuperPilot_Command.Devices;

namespace SuperPilot_Command.Commands
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
