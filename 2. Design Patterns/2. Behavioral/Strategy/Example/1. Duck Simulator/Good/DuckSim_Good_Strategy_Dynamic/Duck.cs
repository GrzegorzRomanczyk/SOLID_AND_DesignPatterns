using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSim_Good_Strategy_Dynamic
{
    public abstract class Duck
    {
        private IFlying flying;
        private IQuacking quacking;

        public Duck(IFlying flying, IQuacking quacking)
        {
            this.flying = flying;
            this.quacking = quacking;
        }

        public abstract void Display();

        public void SetFlying(IFlying flying)
        {
            this.flying = flying;
        }

        public void SetQuacking(IQuacking quacking)
        {
            this.quacking = quacking;
        }

        public void Swim()
        {
            Console.WriteLine("<< kaczka plynie >>");
        }

        public void ExecuteQuack()
        {
            quacking.Quack();
        }

        public void ExecuteFly()
        {
            flying.Fly();
        }
    }
}
