using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound__Duck
{
    public class DuckFactoryWithQuackCounter : DuckAbstractFactory
    {
        public override IQuack CreateDecoyDuck()
        {
            return new QuackCounterDecorator(new DecoyDuck());
        }

        public override IQuack CreateMallardDuck()
        {
            return new QuackCounterDecorator(new MallardDuck());
        }

        public override IQuack CreateRubberDuck()
        {
            return new QuackCounterDecorator(new RubberDuck());
        }

        public override IQuack CreateShovelerDuck()
        {
           return new QuackCounterDecorator(new ShovelerDuck());
        }
    }
}
