using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRecipesTemplateMethodHook
{
    class Program
    {
        static void Main(string[] args)
        {
            var tea = new TeaService();
            tea.PrepareDrink();
            Console.WriteLine("");
            var coffe = new CoffeService();
            coffe.PrepareDrink();
        }
    }
}
