using SuperPilot_Command_2.Commands.Abstractions;
using SuperPilot_Command_2.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPilot_Command_2.Commands
{
    class StereoTurnOnCommand : ICommand
    {
        private readonly Stereo stereo;

        public StereoTurnOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.TurnOn();
            stereo.SetCd();
            stereo.SetVolume(10);
        }
    }
}
