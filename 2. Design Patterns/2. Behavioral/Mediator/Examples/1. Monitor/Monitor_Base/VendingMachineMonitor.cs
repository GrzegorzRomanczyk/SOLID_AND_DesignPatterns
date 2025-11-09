using Monitor_Base.VendingMachineStateCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor_Base
{
    public class VendingMachineMonitor
    {
        private readonly VendingMachineService vendingMachineService;

        public VendingMachineMonitor(VendingMachineService vendingMachineService)
        {
            this.vendingMachineService = vendingMachineService;
        }

        public void Raport()
        {
            Console.WriteLine("Automat sprzedajacy: " + vendingMachineService.Location);
            Console.WriteLine("Towar: " + vendingMachineService.GetCounter() + "szt.");
            Console.WriteLine("Towar: " + vendingMachineService.GetState());
        }
    }
}
