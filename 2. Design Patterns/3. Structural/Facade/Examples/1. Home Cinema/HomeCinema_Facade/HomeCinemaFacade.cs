using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema_Facade
{
    public class HomeCinemaFacade
    {
        private readonly Amplifier amplifier;
        private readonly CdPlayer cdPlayer;
        private readonly Lighting lighting;
        private readonly MediaPlayer mediaPlayer;
        private readonly PopcornMachine popcornMachine;
        private readonly Projector projector;
        private readonly Screen screen;
        private readonly Tuner tuner;

        public HomeCinemaFacade(
            Amplifier amplifier,
            CdPlayer cdPlayer,
            Lighting lighting,
            MediaPlayer mediaPlayer,
            PopcornMachine popcornMachine,
            Projector projector,
            Screen screen,
            Tuner tuner)
        {
            this.amplifier = amplifier;
            this.cdPlayer = cdPlayer;
            this.lighting = lighting;
            this.mediaPlayer = mediaPlayer;
            this.popcornMachine = popcornMachine;
            this.projector = projector;
            this.screen = screen;
            this.tuner = tuner;
        }

        public void PlayMovie(string name)
        {
            Console.WriteLine("Przygotuj sie na seans filmowy!");
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
            mediaPlayer.Play(name);
        }

        public void StopMovie()
        {
            Console.WriteLine("Koniec seansu!");
            popcornMachine.Off();
            lighting.On();
            screen.Up();
            projector.Off();
            amplifier.Off();
            mediaPlayer.Stop();
            mediaPlayer.Off();
        }
    }
}
