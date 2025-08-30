using System;

namespace VendingMachine_StateWithBonus
{
    internal class WithCointState : IState
    {
        Random randonmBonus = new Random();
        private readonly VendingMachineService vendingMachineService;

        public WithCointState(VendingMachineService vendingMachineService)
        {
            this.vendingMachineService = vendingMachineService;
        }

        public void ApprovePurchase()
        {
            Console.WriteLine("Zatwierdzono zakup");
            int bonus = randonmBonus.Next(10);
            if (bonus == 0 && vendingMachineService.GetCounter() > 1)
            {
                vendingMachineService.SetState(vendingMachineService.BonusProduct);
            }
            else
            {
                vendingMachineService.SetState(vendingMachineService.Sold);
            }
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