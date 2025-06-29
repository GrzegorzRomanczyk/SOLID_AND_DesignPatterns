using SuperPilot_Command_2.Commands;
using SuperPilot_Command_2.Commands.Abstractions;
using System.Linq;
using System.Text;

namespace SuperPilot_Command_2
{
    public class SuperPilot
    {
        private ICommand[] turnOnCommands;
        private ICommand[] turnOffCommands;

        public SuperPilot()
        {
            turnOnCommands = new ICommand[7];
            turnOffCommands = new ICommand[7];

            ICommand nullCommand = new NullCommand();
            for (int i = 0; i < 7; i++)
            {
                turnOnCommands[i] = nullCommand;
                turnOffCommands[i] = nullCommand;
            }
        }

        public void SetCommand(int slot, ICommand turnOnCommand, ICommand turnOffCommand)
        {
            turnOnCommands[slot] = turnOnCommand;
            turnOffCommands[slot] = turnOffCommand;
        }

        public void TurnOnButtonPressed(int slot) => turnOnCommands[slot].Execute();

        public void TurnOffButtonPressed(int slot) => turnOffCommands[slot].Execute();

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.Append("---- Super Pilot ----\n");

            for (int i = 0; i < turnOnCommands.Length; i++)
            {
                text.Append("[gniazdo: " + i + "] " 
                    + turnOnCommands[i].GetType().Name
                    + "  " + turnOffCommands[i].GetType().Name + "\n");

            }
            return text.ToString();
        }
    }
}