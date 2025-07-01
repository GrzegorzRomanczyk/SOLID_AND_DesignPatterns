using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema_Facade
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
            var cdPlayer = new CdPlayer("Odtwarzacz CD", amplifier);
            var tuner = new Tuner("Tuner", amplifier);

            var homeCinemaFacade = new HomeCinemaFacade(amplifier, cdPlayer, lighting, mediaPlayer, popcornMachine, projector, screen, tuner);
            homeCinemaFacade.PlayMovie("Wyspa tajemnic");
            Console.WriteLine("----------------------------------------------------------");
            homeCinemaFacade.StopMovie();
            Console.ReadKey();


        }
    }
}
