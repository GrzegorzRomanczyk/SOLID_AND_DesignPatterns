using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound__Duck
{
    public class Observed : IQuackObserver
    {
        List<IObserver> observers = new List<IObserver>();
        IQuackObserver duck;

        public Observed(IQuackObserver duck)
        {
            this.duck = duck;
        }

        public void Notify()
        {
            IEnumerator<IObserver> enumerator = observers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                IObserver observer = enumerator.Current;
                observer.Update(duck);
            }
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }
    }
}
