﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethods
{
    class Void
    {
        public void Squared(int x, int y)
        {
            double result = Math.Pow(x, 2); 
            Console.WriteLine(result);
            Console.WriteLine(y);
            
        }
    }
}
