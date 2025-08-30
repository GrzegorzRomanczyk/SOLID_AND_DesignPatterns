using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
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
            vendingMachineService.ReturnCoin();
            vendingMachineService.ApprovePurchase();
            Console.WriteLine(vendingMachineService);

            vendingMachineService.InsertCoin();
            vendingMachineService.ApprovePurchase();
            vendingMachineService.InsertCoin();
            vendingMachineService.ApprovePurchase();
            vendingMachineService.ReturnCoin();
            Console.WriteLine(vendingMachineService);

            vendingMachineService.InsertCoin();
            vendingMachineService.InsertCoin();
            vendingMachineService.ApprovePurchase();
            vendingMachineService.InsertCoin();
            vendingMachineService.ApprovePurchase();
            vendingMachineService.InsertCoin();
            vendingMachineService.ApprovePurchase();
            Console.WriteLine(vendingMachineService);

            Console.ReadKey();
        }
    }
}
