using Monitor_Base.VendingMachineStateCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            // argumenty zostaly przekazane do VS -> properies -> debug -> application arguments
            if(args.Length <2)
            {
                Console.WriteLine("Automat sprzedajacy <nazwa> <liczbaProduktow>");
                Environment.Exit(1);
            }
            counter = int.Parse(args[1]);
            var vendingMachineService = new VendingMachineService(args[0], counter);
            var monitor = new VendingMachineMonitor(vendingMachineService);
            monitor.Raport();



            Console.ReadKey();
        }
    }
}
