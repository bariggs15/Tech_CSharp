using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy (Press Enter to continue)");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            //ask for name
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.ReadLine();

            //what course are you on
            Console.WriteLine("What course are you on?");
            String course = Console.ReadLine();
            Console.WriteLine(course + " is a good course");
            Console.ReadLine();

            //what page number are you on
            Console.WriteLine("What page number are you on?");
            String pageNumber = Console.ReadLine();
            int page = Convert.ToInt32(pageNumber);
            Console.WriteLine(page + " is a good start!");
            Console.ReadLine();

            Console.WriteLine("Need help with anything? ('true' or 'false')");
            Console.ReadLine();
            bool needHelp = true;
            string helpStatus = Convert.ToString(needHelp);
            Console.WriteLine(helpStatus);
            Console.ReadLine();

            //Positive experience
            Console.WriteLine("Have you had any positive experiences you'd like to share?");
            Console.ReadLine();

            //Feed back
            Console.WriteLine("Any other feedback you'd like to share?");
            Console.ReadLine();

            //Hours studied
            Console.WriteLine("How many hours did you study?");
            string studyHours = Console.ReadLine();
            int hours = Convert.ToInt32(studyHours);
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}

