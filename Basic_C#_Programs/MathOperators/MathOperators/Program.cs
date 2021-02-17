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

            //*****************************BRANCHING ASSIGNMENT********************************

            Console.WriteLine("Welcome to Package Express. Please follow instructions below");

            Console.WriteLine("Please input package weight");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            if (packWeight > 50)
            {
                Console.WriteLine("Package to heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("That's great, please continue...");

            }
                Console.ReadLine();

            Console.WriteLine("what is the height of package?");
            int packHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the width of package?");
            int packWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the length of package?");
            int packLength = Convert.ToInt32(Console.ReadLine());

            int total = (packWidth + packLength + packHeight);

            if (packWeight > 50 || total > 50)
            {

                Console.WriteLine("Your package is too big to be shipped via Package Express. Have a great day");
            }
            else
            {
                int shippingCost = Convert.ToInt32(((packHeight * packLength * packWidth) * packWeight) / 100);
                
                Console.WriteLine("Your estimated total for shipping this package is: $" + shippingCost);
                Console.ReadLine();
            }

        


        //********************BRANCHING (TERNARY OPERATOR)********************************


        //Console.WriteLine("what is your favorite number?");
        //int favNum = Convert.ToInt32(Console.ReadLine());

        //string results = favNum == 12 ? "you have an awesome fav number" : "You do not have an awersome fav number";
        //Console.WriteLine(results);
        //Console.ReadLine();

        //int roomTemp = 70;

        //Console.WriteLine("Hi what is your name?");
        //string name = Console.ReadLine();

        //Console.WriteLine("Hi" + name + ", what is the temp where you are?");
        //int currentTemp = Convert.ToInt32(Console.ReadLine());

        //if (currentTemp == roomTemp)
        //{
        //    Console.WriteLine("it is exactly room temp");
        //}
        //else if (currentTemp > roomTemp)
        //{
        //    Console.WriteLine("it is warmer than room temp");
        //}
        //else if (currentTemp < roomTemp)
        //{
        //    Console.WriteLine("it is cooler than room temp");
        //}
        //else
        //{
        //    Console.WriteLine("something went wrong");
        //}
        //Console.ReadLine();

        //int currentTemp = 50;
        //int roomTemp = 70;

        //string comparisonResults = currentTemp == roomTemp ? "It is room temp." : "It is not room temp.";
        //Console.WriteLine(comparisonResults);
        //Console.ReadLine();

        //if (currentTemp == roomTemp)
        //{
        //    Console.WriteLine("it is exactly room temp.");
        //}
        //else if (currentTemp > roomTemp)
        //{
        //    Console.WriteLine("it is warmer than room temp");
        //}

        //else if (currentTemp < roomTemp)
        //{
        //    Console.WriteLine("it is cooler than room temp");
        //}
        //else
        //{
        //    Console.WriteLine("it is not room temp");
        //}
        //Console.ReadLine();

        //**************************MORE PRACTICE WITH COMPARATOR OPERATORS**********************************

        //Console.WriteLine("How old are you?");
        //int age = Convert.ToInt32(Console.ReadLine());

        //if (age >= 16)
        //{
        //    Console.WriteLine("you can get a DL");
        //}
        //else
        //{ 
        //    Console.WriteLine("the roads are much safer");
        //}
        //Console.ReadLine();

        //int salary = 40000;

        //if (salary <=38000)
        //{
        //    Console.WriteLine("you can't buy a car");
        //}
        //else
        //{
        //    Console.WriteLine("Buy something modest");
        //}
        //Console.ReadLine();


        //Console.WriteLine("What is your favorite fruit?");
        // string fruit = Console.ReadLine();

        //if (fruit == "orange") 
        //{
        //    Console.WriteLine("your favorite fruit is orange");
        //}
        //else if (fruit == "tomato")
        //{
        //    Console.WriteLine("your favorite fruit is tomato");
        //}
        //else
        //{
        //    Console.WriteLine("Your favorite fruit is something else...");

        //}
        //Console.ReadLine();


        //Console.WriteLine("What is your favorite number?");
        //int num1 = Convert.ToInt32(Console.ReadLine());

        //if (num1 != 15)
        //{
        //    Console.WriteLine("you are nuts");
        //}

        //else
        //{
        //    Console.WriteLine("You know what the best number is");

        //}
        //Console.ReadLine();


        //*************************************BOOLEAN LOGIC ASSIGNMENT***********************************

        //Console.WriteLine("what is your age?");
        //int age = Convert.ToInt32(Console.ReadLine());


        //Console.WriteLine("Have you ever had a DUI (true or false)?");
        //bool DUI = Convert.ToBoolean(Console.ReadLine());

        //Console.WriteLine("how many speeding tickets do you have?");
        //int tickets = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Do you qualify?  " + (age>15 && (DUI == false) && tickets < 3) );
        //Console.ReadLine();


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
