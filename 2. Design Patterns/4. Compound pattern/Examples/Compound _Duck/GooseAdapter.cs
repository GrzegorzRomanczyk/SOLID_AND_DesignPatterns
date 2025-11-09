using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound__Duck
{
    public class GooseAdapter : IQuack
    {
        private readonly Goose goose;
        private readonly Observed observed;

        public void Notify()
        {
            observed.Notify();
        }

        public void Subscribe(IObserver observer)
        {
            observed.Subscribe(observer);
        }


        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
            observed = new Observed(this);
        }

        public void Quack()
        {
            goose.Honks();
            Notify();
        }
    }
}
