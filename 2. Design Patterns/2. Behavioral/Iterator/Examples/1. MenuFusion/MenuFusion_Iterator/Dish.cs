using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuFusion_Iterator
{
    public class Dish
    {
        public string Name { get; }
        public string Description { get; }
        public bool IsWege { get; }
        public decimal Price { get; }

        public Dish(string name, string description, bool isWege, decimal price)
        {
            Name = name;
            Description = description;
            IsWege = isWege;
            Price = price;
        }
    }
}
