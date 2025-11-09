using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound__Duck
{
    public class QuackCounterDecorator : IQuack
    {
        private readonly IQuack duck;
        public static int QuackCount { get; private set; }

        public QuackCounterDecorator(IQuack duck)
        {
            this.duck = duck;
        }

        public void Quack()
        {
            duck.Quack();
            QuackCount++;
            Notify();
        }

        public void Subscribe(IObserver observer)
        {
            duck.Subscribe(observer);
        }

        public void Notify()
        {
            duck.Notify();
        }
    }
}
