using System;
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

            //*************************************BOOLEAN LOGIC ASSIGNMENT***********************************

            Console.WriteLine("what is your age?");
            int age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Have you ever had a DUI (true or false)?");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("how many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you qualify?  " + (age>15 && (DUI == false) && tickets < 3) );
            Console.ReadLine();


            //************************************BOOLEAN OPERATORS*************************************************************

            ////&& operator
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);
            //Console.ReadLine();

            //// || operator
            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);
            //Console.ReadLine();

            ////== operator
            //Console.WriteLine(true ==false);
            //Console.WriteLine(true == true);
            //Console.WriteLine(false == false);
            //Console.ReadLine();

            //// != operator
            //Console.WriteLine(true != false);
            //Console.WriteLine(true != true);
            //Console.WriteLine(false != false);
            //Console.ReadLine();

            //// Xor operator (if one is true, it's true... but not both)
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(true ^ true);
            //Console.WriteLine(false ^ false);
            //Console.ReadLine();

            //***************************************PRACTICE INCOME COMPARISON ASSIGNMENT*************************************************

            //Console.WriteLine("Anonymous Income Comparison Program" + "-------------------");


            //Console.WriteLine("person1");
            //Console.WriteLine("What is hourly rate for person1?");
            //int hourRate1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("What is number of hours worked per week?");
            //int hoursWorked1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("person2");
            //Console.WriteLine("What is hourly rate for person2?");
            //int hourRate2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("What is number of hours worked per week?");
            //int hoursWorked2 = Convert.ToInt32(Console.ReadLine());

            //int annualSal1 = (hourRate1 * hoursWorked1 * 52);
            //int annualSal2 = (hourRate2 * hoursWorked2 * 52);

            //Console.WriteLine("Annual salary of person1: " + annualSal1);

            //Console.WriteLine("Annual salary of person2: " + annualSal2);

            //Console.WriteLine("Does person1 make more money than person2: " + (annualSal1 > annualSal2));

            //Console.ReadLine();


            ///*********************** PRACTICE MATH OPERATORS***************************************************************
            //Console.WriteLine("write a number here:");
            //int mult1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("your number x50 is: " + mult1 * 50);

            //Console.WriteLine("your number + 25 is: " + (mult1 + 25));

            //Console.WriteLine("your number / 12.5  is: " + mult1 / 12.5);

            //Console.WriteLine("true or false: your number is > 50: " + (mult1 > 50));

            //Console.WriteLine("your number / 7  is: " + mult1 % 7);

            //Console.ReadLine();


            // ******************************** PRACTICE WITH DATA TYPES*********************************

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
