using System;

namespace Monitor_Base.VendingMachineStateCode
{
    internal class Sold : IState
    {
        private readonly VendingMachineService vendingMachineService;

        public Sold(VendingMachineService vendingMachineService)
        {
            this.vendingMachineService = vendingMachineService;
        }

        public void ApprovePurchase()
        {
            Console.WriteLine("Nie dostaniesz produktu tylko dlatego, że potwierdzileś drugi raz");
        }

        public void DeliverProduct()
        {
            vendingMachineService.UnlockProduct();
            if (vendingMachineService.GetCounter() > 0)
            {
                vendingMachineService.SetState(vendingMachineService.NoCoin);
            }
            else
            {
                Console.WriteLine("Ups, brak produktu w automacie");
                vendingMachineService.SetState(vendingMachineService.Empty);
            }
        }

        public void InsertCoin()
        {
            Console.WriteLine("Proszę czekać na wydanie produktu");
        }

        public void ReturnCoin()
        {
            Console.WriteLine("Niestety nie można zwrócić monety po zatwierdzeniu zakupu");
        }
    }
}