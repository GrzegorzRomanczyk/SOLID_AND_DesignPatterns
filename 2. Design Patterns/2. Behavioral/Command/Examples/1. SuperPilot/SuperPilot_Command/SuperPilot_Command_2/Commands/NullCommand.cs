using SuperPilot_Command_2.Commands.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPilot_Command_2.Commands
{
    public class NullCommand : ICommand
    {
        public void Execute()
        { 
        }
    }
}
