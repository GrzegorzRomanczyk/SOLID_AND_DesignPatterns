using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound__Duck
{
    public abstract class DuckAbstractFactory
    {
        public abstract IQuack CreateMallardDuck();
        public abstract IQuack CreateShovelerDuck();
        public abstract IQuack CreateDecoyDuck();
        public abstract IQuack CreateRubberDuck();
    }
}
