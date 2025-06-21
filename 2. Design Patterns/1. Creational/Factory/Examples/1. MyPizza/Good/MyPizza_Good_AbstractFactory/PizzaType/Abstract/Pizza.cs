using MyPizza_Good_AbstractFactory.PizzaIngredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPizza_Good_AbstractFactory.PizzaType.Abstract
{
    public abstract class Pizza
    {
        protected string name;

        protected Dough dough;
        protected Dip dip;
        protected List<Vegetables> vegetables;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Mussels mussels;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Pieczenie: 25 minut w temperaturze 180 stopni");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Krojenie pizzy na 8 kawalkow");
        }

        public void Pack()
        {
            Console.WriteLine("Pakowanie pizzy do kwadratowego pudelka");
        }

        public void SetName(string name) => this.name = name;

        public string GetName() => name;

        public override string ToString()
        {
            StringBuilder wyniki = new StringBuilder();
            wyniki.Append("---- " + name + " ----\n");
            if (dough != null)
            {
                wyniki.Append(dough);
                wyniki.Append("\n");
            }
            if (dip != null)
            {
                wyniki.Append(dip);
                wyniki.Append("\n");
            }
            if (cheese != null)
            {
                wyniki.Append(cheese);
                wyniki.Append("\n");
            }
            if (vegetables != null)
            {
                for (int i = 0; i < vegetables.Count; i++)
                {
                    wyniki.Append(vegetables[i]);
                    if (i < vegetables.Count - 1)
                    {
                        wyniki.Append(", ");
                    }
                }
                wyniki.Append("\n");
            }
            if (mussels != null)
            {
                wyniki.Append(mussels);
                wyniki.Append("\n");
            }
            if (pepperoni != null)
            {
                wyniki.Append(pepperoni);
                wyniki.Append("\n");
            }
            return wyniki.ToString();
        }
    }
}