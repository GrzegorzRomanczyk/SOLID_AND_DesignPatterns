using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Chocolate_Singleton_2XLock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testujemy Singleton z wieloma wątkami...\n");

            Task[] tasks = new Task[2];

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    var instance = ChocolateBoiler.GetInstance();
                    Console.WriteLine($"Wątek {Task.CurrentId}: instancja ID = {instance.GetHashCode()}");

                    instance.Fill();
                    instance.Boil();
                    instance.Drain();
                });
            }

            Task.WaitAll(tasks);

            Console.WriteLine("\nTest zakończony. Wciśnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}
