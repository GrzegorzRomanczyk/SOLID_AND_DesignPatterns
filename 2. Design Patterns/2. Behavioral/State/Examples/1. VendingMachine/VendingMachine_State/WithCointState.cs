using System;

namespace VendingMachine_State
{
    internal class WithCointState : IState
    {
        private readonly VendingMachineService vendingMachineService;

        public WithCointState(VendingMachineService vendingMachineService)
        {
            this.vendingMachineService = vendingMachineService;
        }

        public void ApprovePurchase()
        {
            Console.WriteLine("Zatwierdzono zakup");
            vendingMachineService.SetState(vendingMachineService.Sold);
            //currentState = SOLD;
            //DeliverProduct();
        }

        public void DeliverProduct()
        {
            Console.WriteLine("Nie wydano produktu");
        }

        public void InsertCoin()
        {
            Console.WriteLine("Nie można włożyć wiecej niz jednej monety");
        }

        public void ReturnCoin()
        {
            Console.WriteLine("Moneta zwrocona");
            vendingMachineService.SetState(vendingMachineService.NoCoin);
            //currentState = NO_COIN;
        }
    }
}