﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperators
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("write a number here:");
            int mult1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("your number x50 is: " + mult1 * 50);

            Console.WriteLine("your number + 25 is: " + (mult1 + 25));

            Console.WriteLine("your number / 12.5  is: " + mult1 / 12.5);

            Console.WriteLine("true or false: your number is > 50: " + (mult1 > 50));

            Console.WriteLine("your number / 7  is: " + mult1 % 7);

            Console.ReadLine();


           
            //int num1 = 20;
            //int num2 = 5;
            //int addTotal = num1 + num2;
            //Console.WriteLine(addTotal);
            //int subTotal = num1 - num2;
            //Console.WriteLine(subTotal);
            //int multTotal = num1 * num2;
            //Console.WriteLine(multTotal);
            //int divTotal = num1 / num2;
            //Console.WriteLine(divTotal);


            //Console.ReadLine();

            //float num3 = 5.5f;

            //float addtotal1 = num1 + num3;
            //Console.WriteLine(addtotal1);


            //int addtotal2 = num1 + Convert.ToInt32(num3);
            //Console.WriteLine(addtotal2);

            //Console.ReadLine();

            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("ten minus five =" + difference.ToString());
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //    bool trueOrFalse = 12 > 5;
            //    Console.WriteLine(trueOrFalse.ToString());
            //    Console.ReadLine();
            //    bool trueOrFalse2 = 12 < 5;
            //    Console.WriteLine(trueOrFalse2.ToString());
            //    Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 72;

            //bool isWarm = currentTemperature > roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 68;

            //bool isWarm = currentTemperature >= roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //    int roomTemperature = 70;
            //    int currentTemperature = 72;

            //    //bool isWarm = currentTemperature == roomTemperature;
            //    bool isWarm = currentTemperature != roomTemperature;
            //    Console.WriteLine(isWarm);
            //    Console.ReadLine();
        }
    }
}