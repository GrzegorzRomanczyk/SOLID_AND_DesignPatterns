﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckAdapter
{
    public class TurkeyAdapter : IDuck
    {
        private readonly ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly() 
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }

        public void Quack() => turkey.Gurgles();
    }
}
