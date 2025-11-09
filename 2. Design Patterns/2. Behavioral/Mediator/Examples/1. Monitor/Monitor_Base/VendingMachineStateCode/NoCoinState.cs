using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor_Base.VendingMachineStateCode
{
    public class NoCoinState : IState
    {
        private readonly VendingMachineService vendingMachineService;

        public NoCoinState(VendingMachineService vendingMachineService)
        {
            this.vendingMachineService = vendingMachineService;
        }

        public void ApprovePurchase()
        {
            Console.WriteLine("Zanim zatwierdzisz zakup należy wrzucić monete");
        }

        public void DeliverProduct()
        {
            Console.WriteLine("Nie włożyłeś monety");
        }

        public void InsertCoin()
        {
            Console.WriteLine("Moneta przyjęta");
            vendingMachineService.SetState(vendingMachineService.WithCoin);
            //currentState = WITH_COIN;
        }

        public void ReturnCoin()
        {
            Console.WriteLine("Najpierw zaplac");
        }
    }
}
