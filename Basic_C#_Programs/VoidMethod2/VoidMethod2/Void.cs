﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod2
{
    class Void
    {
        public void div2int(int x)
        {
            int result = (x / 2);
            Console.WriteLine("your number divided by two:" + result);
        }
           
       public void div2int(out int x)
        {
            x = 5;
            
        }
    }
}
            //if (x % 2 == 0)
            //{
            //    return x / 2;
            //}
            //else
            //{
            //    return Convert.ToDouble(null); 
            //}