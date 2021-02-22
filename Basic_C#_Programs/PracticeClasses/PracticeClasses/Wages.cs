using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    class Wages
    {
        public int weeklyWage(int x)
        {
            return x * 40;
        }
        public int weeklyWage(decimal x)
        {
            return Convert.ToInt32(x * 8);
        }
        public int weeklyWage(string x)
        {
         
            return Convert.ToInt32(x) * 40 * 52;
             
        }

    }
}

        //decimal result = x * 40;
        //return Convert.ToInt32(result);