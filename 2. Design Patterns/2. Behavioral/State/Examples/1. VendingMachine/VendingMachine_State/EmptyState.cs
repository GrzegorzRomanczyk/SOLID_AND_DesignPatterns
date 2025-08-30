namespace VendingMachine_State
{
    internal class EmptyState : IState
    {
        private readonly VendingMachineService vendingMachineService;

        public EmptyState(VendingMachineService vendingMachineService)
        {
            this.vendingMachineService = vendingMachineService;
        }   

        public void ApprovePurchase()
        {
            System.Console.WriteLine("Zatwierdziles, ale automat jest pusty");
        }

        public void DeliverProduct()
        {
            System.Console.WriteLine("Nie wydano gumy");
        }

        public void InsertCoin()
        {
            System.Console.WriteLine("Nie możesz włożyć monety, gdy automat jest pusty");
        }

        public void ReturnCoin()
        {
            System.Console.WriteLine("Nie włożyłeś monety");
        }
    }
}