using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuFusion_Iterator
{
    public class BreakfastMenuIterator : Iterator
    {
        private readonly ArrayList dishes;
        private int dishCounter;

        public BreakfastMenuIterator(ArrayList dishes)
        {
            this.dishes = dishes;
        }

        public bool HasNext()
        {
            if (dishCounter >= dishes.Count || dishes[dishCounter] == null)
            {
                return false;
            }
            return true;
        }

        public Dish Next()
        {
            Dish dish = (Dish)dishes[dishCounter];
            dishCounter++;
            return dish;
        }
    }
}
