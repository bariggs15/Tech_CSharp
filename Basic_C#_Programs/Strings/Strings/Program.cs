using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "my name is Austin, ";
            string color = "my favorite color is blue, ";
            string sport = "my favorite sport is basketball.";

            Console.WriteLine(name + color + sport);
            Console.ReadLine();

            sport = sport.ToUpper();
            Console.WriteLine(sport);
            Console.ReadLine();

            StringBuilder parag = new StringBuilder();
            parag.Append("I like tomatoes");
            Console.WriteLine(parag);
            Console.ReadLine();
            parag.Append("\n I like onions");
            Console.WriteLine(parag);
            Console.ReadLine();
            parag.Append("\n I do not like cauliflower");
            Console.WriteLine(parag);
            Console.ReadLine();


            //string name = "Austin";

            //string quote="the man said, \"Hello\"" + name + "\n Hello on new line. \n \t hello on new tab.";
            //string fileName = @"C:\Users\Austin";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.StartsWith("B");

            //int length = name.Length;

            //name = name.ToUpper();

            ////// strings are immutable-------------------- no changes can be made------------

            //StringBuilder sb = new StringBuilder();

            //sb.Append("my name is austin");

            //Console.WriteLine(sb);
            //Console.ReadLine();
        }
    }
}
