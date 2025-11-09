using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound__Duck
{
    public interface IQuackObserver
    {
        void Subscribe(IObserver observer);
        void Notify();
    }
}
