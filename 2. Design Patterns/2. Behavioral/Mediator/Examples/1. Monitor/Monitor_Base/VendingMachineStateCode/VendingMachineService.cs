using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor_Base.VendingMachineStateCode
{
    public class VendingMachineService
    {
        public IState Empty { get; }
        public IState NoCoin { get; }
        public IState WithCoin { get; }
        public IState Sold { get; }
        public IState BonusProduct { get; }
        public string Location { get; }

        private IState currentState;
        private int productCounter = 0;

        public override string ToString()
        {
            return $"\nAutomat do sprzedaży produktów.\nZapas produktów: {productCounter}.\nObecny stan {currentState}\n";
        }

        public IState GetState() => currentState;

        public VendingMachineService(string location, int productCounter)
        {
            Empty = new EmptyState(this);
            NoCoin = new NoCoinState(this);
            WithCoin = new WithCointState(this);
            Sold = new Sold(this);
            BonusProduct = new BonusProductState(this);
            Location = location;
            this.productCounter = productCounter;
            if (productCounter > 0)
            {
                currentState = NoCoin;
            }
            else
            {
                currentState = Empty;
            }
        }

        public void ApprovePurchase()
        {
            currentState.ApprovePurchase();
            currentState.DeliverProduct();
        }

        public void InsertCoin()
        {
            currentState.InsertCoin();
        }

        public void ReturnCoin()
        {
            currentState.ReturnCoin();
        }

        public void SetState(IState state)
        {
            this.currentState = state;
        }

        public void UnlockProduct()
        {
            Console.WriteLine("Produkt wypada");
            if (productCounter > 0)
            {
                productCounter -= 1;
            }
        }
        public int GetCounter()
        {
            return productCounter;
        }
    }
}
