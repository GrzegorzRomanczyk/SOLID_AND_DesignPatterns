﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSim_Good_Strategy_Dynamic
{
    public class CantFly : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Nie potrafie latac");
        }
    }
}
