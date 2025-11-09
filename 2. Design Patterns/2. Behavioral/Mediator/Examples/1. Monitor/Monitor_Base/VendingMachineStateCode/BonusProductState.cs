using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor_Base.VendingMachineStateCode
{
    public class BonusProductState : IState
    {
        private readonly VendingMachineService vendingMachineService;

        public BonusProductState(VendingMachineService vendingMachineService)
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
            if (vendingMachineService.GetCounter() == 0)
            {
                vendingMachineService.SetState(vendingMachineService.Empty);
            }
            else
            {
                vendingMachineService.UnlockProduct();
                Console.WriteLine("Wygrales! Dostaniesz drugi produkt gratis");
                if (vendingMachineService.GetCounter() > 0)
                {
                    vendingMachineService.SetState(vendingMachineService.NoCoin);
                }
                else
                {
                    Console.WriteLine("Ups, koniec produktow");
                    vendingMachineService.SetState(vendingMachineService.Empty);
                }
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
