using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound__Duck
{
    public class Flock : IQuack
    {
        List<IQuack> birdsInFlock = new List<IQuack>();

        public void AddToFlock(IQuack bird)
        {
            birdsInFlock.Add(bird);
        }

        public void Notify()
        {
        }

        public void Quack()
        {
            IEnumerator<IQuack> iterator = birdsInFlock.GetEnumerator();
            while(iterator.MoveNext())
            {
                IQuack bird = iterator.Current;
                bird.Quack();
            }
        }

        public void Subscribe(IObserver observer)
        {
            IEnumerator<IQuack> enumerator = birdsInFlock.GetEnumerator();
            while (enumerator.MoveNext())
            {
                IQuack bird = enumerator.Current;
                bird.Subscribe(observer);
            }
        }
    }
}
