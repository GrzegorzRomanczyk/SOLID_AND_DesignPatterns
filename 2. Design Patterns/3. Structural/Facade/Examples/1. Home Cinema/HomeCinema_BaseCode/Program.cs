using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema_BaseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var popcornMachine = new PopcornMachine("Maszyna do popcornu");
            var lighting = new Lighting("Oświetlenie");
            var screen = new Screen("Ekran");
            var projector = new Projector("Projektor");
            var amplifier = new Amplifier("Wzmacniacz");
            var mediaPlayer = new MediaPlayer("Odtwarzacz multimediow", amplifier);


            popcornMachine.On();
            popcornMachine.PreparePopcorn();

            lighting.Dim(10);

            screen.Down();

            projector.On();
            projector.SetWidescreenMode();

            amplifier.On();
            amplifier.SetMediaPlayer(mediaPlayer);
            amplifier.SetSurroundSound();
            amplifier.SetVolume(10);

            mediaPlayer.On();
            mediaPlayer.Play("Wyspa tajemnic");

            Console.ReadKey();
        }
    }
}
