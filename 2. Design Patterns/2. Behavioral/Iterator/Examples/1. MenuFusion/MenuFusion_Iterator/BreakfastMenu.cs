using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuFusion_Iterator
{
    public class BreakfastMenu
    {
        ArrayList dishes;

        public BreakfastMenu()
        {
            dishes = new ArrayList();
            AddDish("Nalesnik standard", "Nalesnik z jajkiem i kielbasa", false, 20.00m);
            AddDish("Nalesnik z owocami", "Nalesnik z jagodami i malinami", true, 20.00m);
            AddDish("Nalesnik z miesem", "Nalesnik z szarpana wolowina", false, 23.00m);
        }

        public Iterator CreateIterator() => new BreakfastMenuIterator(dishes);

        private void AddDish(string name, string description, bool isWege, decimal price)
        {
            var dish = new Dish(name, description, isWege, price);
            dishes.Add(dish);
        }
    }
}
