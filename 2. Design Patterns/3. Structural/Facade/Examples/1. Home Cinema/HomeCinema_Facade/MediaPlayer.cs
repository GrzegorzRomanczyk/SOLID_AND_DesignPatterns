using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema_Facade
{
    public class MediaPlayer
    {
        private readonly string description;
        private string movie;
        private int currentTruck;
        private readonly Amplifier amplifier;

        public MediaPlayer(string description, Amplifier amplifier)
        {
            this.description = description;
            this.amplifier = amplifier;
        }

		public void On()
		{
			Console.WriteLine($"{description} : włączony");
		}

		public void Off()
		{
			Console.WriteLine($"{description} : wyłączony");
		}

		public void Play(string movie)
		{
			this.movie = movie;
			currentTruck = 0;
			Console.WriteLine($"{description} : odtwarzanie filmu {movie}");
		}

		public void Play(int currentTruck)
		{
			if (movie == null)
			{
				Console.WriteLine($"{description} : nie można odtworzyć fragmentu {currentTruck}, gdyż nie wybrano filmu");
			}
			else
			{
				this.currentTruck = currentTruck;
				Console.WriteLine($"{description} : odtwarzanie fragmentu {currentTruck}, movie {movie}");
			}
		}

		public void Stop()
		{
			currentTruck = 0;
			Console.WriteLine($"{description} : zatrzymanu {movie}");
		}

		public void Pause()
		{
			Console.WriteLine($"{description} : wstrzymano odtwarzanie {movie}");
		}

		public void ustawDźwiękDwukanałowy()
		{
			Console.WriteLine($"{description} : wybrano dźwięk dwukanałowy");
		}

		public void ustawDźwiękPrzestrzenny()
		{
			Console.WriteLine($"{description} : wybrano dźwięk przestrzenny");
		}

		public override string ToString() => description;
	}
}
