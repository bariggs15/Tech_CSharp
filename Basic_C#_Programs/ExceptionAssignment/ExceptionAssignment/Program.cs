﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            double age1 = Convert.ToDouble(Console.ReadLine());

            DateTime date = DateTime.Now;

            try
            {
                Console.WriteLine((date.Year) - age1);
                Console.ReadLine();
            }
            catch
            {
                
            }
            
        }
    }
}
