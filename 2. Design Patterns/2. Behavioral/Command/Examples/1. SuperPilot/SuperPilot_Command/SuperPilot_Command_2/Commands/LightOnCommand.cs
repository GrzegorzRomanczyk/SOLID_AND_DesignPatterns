using SuperPilot_Command_2.Commands.Abstractions;
using SuperPilot_Command_2.Devices;

namespace SuperPilot_Command_2.Commands
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
