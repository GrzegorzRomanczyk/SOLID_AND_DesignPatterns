using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound__Duck
{
    public class DuckFactory : DuckAbstractFactory
    {
        public override IQuack CreateDecoyDuck()
        {
            return new DecoyDuck();
        }

        public override IQuack CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuack CreateRubberDuck()
        {
            return new RubberDuck();
        }

        public override IQuack CreateShovelerDuck()
        {
            return new ShovelerDuck();
        }
    }
}
