using SuperPilot_Command.Commands.Abstractions;
using SuperPilot_Command.Devices;

namespace SuperPilot_Command.Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOn();
        }
    }
}
