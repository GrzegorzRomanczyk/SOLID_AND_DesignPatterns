using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuFusion_Iterator
{
    public class LunchMenuIterator : Iterator
    {
        private readonly Dish[] dishes;
        private int dishCounter;

        public LunchMenuIterator(Dish[] dishes)
        {
            this.dishes = dishes;
        }

        public bool HasNext()
        {
            if (dishCounter >= dishes.Length || dishes[dishCounter] == null)
            {
                return false;
            }
            return true;
        }

        public Dish Next()
        {
            Dish dish = dishes[dishCounter];
            dishCounter++;
            return dish;
        }
    }
}
