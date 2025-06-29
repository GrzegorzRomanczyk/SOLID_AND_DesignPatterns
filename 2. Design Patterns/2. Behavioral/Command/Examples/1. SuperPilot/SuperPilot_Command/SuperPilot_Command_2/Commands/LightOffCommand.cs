using SuperPilot_Command_2.Commands.Abstractions;
using SuperPilot_Command_2.Devices;

namespace SuperPilot_Command_2.Commands
{
    internal class LightOffCommand : ICommand
    {
        private readonly Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOff();
        }
    }
}