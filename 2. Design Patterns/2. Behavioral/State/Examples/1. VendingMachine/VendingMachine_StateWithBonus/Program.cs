using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_StateWithBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            var vendingMachineService = new VendingMachineService(5);
            Console.WriteLine(vendingMachineService);

            vendingMachineService.InsertCoin();
            vendingMachineService.ApprovePurchase();

            Console.WriteLine(vendingMachineService);

            vendingMachineService.InsertCoin();
            vendingMachineService.ApprovePurchase();

            Console.WriteLine(vendingMachineService);

            vendingMachineService.InsertCoin();
            vendingMachineService.ApprovePurchase();

            Console.WriteLine(vendingMachineService);
            Console.ReadKey();
        }
    }
}
