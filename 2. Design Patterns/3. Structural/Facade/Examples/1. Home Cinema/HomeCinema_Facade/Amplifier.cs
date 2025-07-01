using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema_Facade
{
    public class Amplifier
    {
        private readonly string description;
        private Tuner tuner;
        private MediaPlayer mediaPlayer;

        public Amplifier(string description)
        {
            this.description = description;
        }

        public void On()
        {
            Console.WriteLine($"{description} : włączony");
        }

        public void Off()
        {
            Console.WriteLine($"{description} : wyłączony");
        }

        public override string ToString() => description;

        public void SetStereoSound()
        {
            Console.WriteLine($"{description} : wyłączono dzwiek stero");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine($"{description} : włączono dźwięk przestrzenny (5 głośników, 1 subwoofer)");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"{description} : głośność ustawiona na wartość {level}");
        }

        public void SetTuner(Tuner tuner)
        {
            Console.WriteLine($"{description} : wybrano tuner {mediaPlayer}");
            this.tuner = tuner;
        }

        public void SetMediaPlayer(MediaPlayer mediaPlayer)
        {
            Console.WriteLine($"{description} : wybrano odtwarzacz multimediów {mediaPlayer}");
            this.mediaPlayer = mediaPlayer;
        }
    }
}
