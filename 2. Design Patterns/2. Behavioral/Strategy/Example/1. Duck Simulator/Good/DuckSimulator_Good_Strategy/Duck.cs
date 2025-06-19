using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator_Good_Strategy
{
    public abstract class Duck
    {
        private readonly IFlying flying;
        private readonly IQuacking quacking;

        public Duck(IFlying flying, IQuacking quacking)
        {
            this.flying = flying;
            this.quacking = quacking;
        }

        public abstract void Display();

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
