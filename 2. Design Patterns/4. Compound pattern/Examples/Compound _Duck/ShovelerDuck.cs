using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound__Duck
{
    public class ShovelerDuck : IQuack
    {

        private readonly Observed observed;

        public ShovelerDuck()
        {
            observed = new Observed(this);
        }


        public void Notify()
        {
            observed.Notify();
        }

        public void Subscribe(IObserver observer)
        {
            observed.Subscribe(observer);
        }

        public void Quack()
        {
            Console.WriteLine("Kwa! Kwa!");
            Notify();
        }
    }
}
