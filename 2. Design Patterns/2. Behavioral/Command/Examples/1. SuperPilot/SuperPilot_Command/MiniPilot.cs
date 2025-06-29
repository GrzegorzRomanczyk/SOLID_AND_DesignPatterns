using SuperPilot_Command.Commands.Abstractions;

namespace SuperPilot_Command
{
    public class MiniPilot
    {
        private ICommand command;

        public MiniPilot(ICommand command)
        {
            this.command = command;
        }

        public MiniPilot() { }

        // pozwala zmienic polecenie, gniazdo pilotu na inne urzadzenie
        public void SetCommand(ICommand command) => this.command = command;

        public void ButtonPressed()
        {
            command.Execute();
        }
    }
}
