﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator_Good_Strategy
{
    public class CantFly : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Nie potrafie latac");
        }
    }
}
