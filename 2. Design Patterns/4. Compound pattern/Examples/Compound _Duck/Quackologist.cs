using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound__Duck
{
    public class Quackologist : IObserver
    {
        public void Update(IQuackObserver duck)
        {
            Console.WriteLine($"Kwakolog: {duck} wlasnie zakwakala");
        }
    }
}
