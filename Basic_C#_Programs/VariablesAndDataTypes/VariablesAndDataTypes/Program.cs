using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////this is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is:" + yourName);
            //Console.ReadLine();

            //Console.WriteLine("what is your favorite number?");
            ////int favoriteNumber = Console.ReadLine(); //can't be a int at readline... needs to be a string
            //string favoriteNumber = Console.ReadLine();
            //Console.WriteLine("Your favorite number is :" + favoriteNumber);
            //Console.ReadLine();

            //Console.WriteLine("what is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 :" + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -24;
            char questionMark = '\u2103';

            double heightInCentimeters = 2123213123123;
            float secondsLeft = 2062f;
            short tempOnMars = -341;

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();

            Console.WriteLine(questionMark);
            Console.ReadLine();
        }
    }
}
