using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor_Base.VendingMachineStateCode
{
    public interface IState
    {
        void InsertCoin();
        void ReturnCoin();
        void ApprovePurchase();
        void DeliverProduct();
    }
}
