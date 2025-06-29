using SuperPilot_Command_2.Commands;
using SuperPilot_Command_2.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPilot_Command_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestSuperPilot();
            Console.WriteLine("A teraz z lambda");
            Console.Clear();
            TestSuperPilotWithLambda();
        }

        public static void TestSuperPilotWithLambda() 
        {
            var superPilot = new SuperPilot();

            var light = new Light();
            var garageDoor = new GarageDoor();
            var stereo = new Stereo();

            superPilot.SetCommand(0, new LambdaCommand(() => light.TurnOn()), new LambdaCommand(() => light.TurnOff()));
            superPilot.SetCommand(1, new LambdaCommand(() => garageDoor.Open()), new LambdaCommand(() => garageDoor.Close()));
            superPilot.SetCommand(2, new LambdaCommand(() => stereo.TurnOn()), new LambdaCommand(() => stereo.TurnOff()));

            Console.WriteLine(superPilot);

            superPilot.TurnOnButtonPressed(0);
            superPilot.TurnOffButtonPressed(0);

            superPilot.TurnOnButtonPressed(1);
            superPilot.TurnOffButtonPressed(1);

            superPilot.TurnOnButtonPressed(2);
            superPilot.TurnOffButtonPressed(2);

            Console.ReadKey();
        }

        public static void TestSuperPilot()
        {
            var superPilot = new SuperPilot();

            var light = new Light();
            var garageDoor = new GarageDoor();
            var stereo = new Stereo();

            var lightOnCommand = new LightOnCommand(light);
            var lightOffCommand = new LightOffCommand(light);

            var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
            var garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor);

            var stereoTurnOnCommand = new StereoTurnOnCommand(stereo);
            var stereoTurnOffCommand = new StereoTurnOffCommand(stereo);

            superPilot.SetCommand(0, stereoTurnOnCommand, stereoTurnOffCommand);
            superPilot.SetCommand(1, lightOnCommand, lightOffCommand);
            superPilot.SetCommand(2, garageDoorOpenCommand, garageDoorCloseCommand);

            Console.WriteLine(superPilot);

            superPilot.TurnOnButtonPressed(0);
            superPilot.TurnOffButtonPressed(0);

            superPilot.TurnOnButtonPressed(1);
            superPilot.TurnOffButtonPressed(1);

            superPilot.TurnOnButtonPressed(2);
            superPilot.TurnOffButtonPressed(2);

            Console.ReadKey();
        }
    }
}
