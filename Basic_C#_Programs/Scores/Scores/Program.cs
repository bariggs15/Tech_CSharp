using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\n Welcome back {uName}. Today is {date}";
            Console.WriteLine(msg);

            string path = @"C:\Users\arigg\source\Tech_C#\Tech_CSharp\Basic_C#_Programs\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0.0;

            Console.WriteLine("\nStudent Scores: \n");
            foreach(string line in lines)
            {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\n Total of " + lines.Length + " student scores. \tAverage Score: " + avgScore);

            Console.WriteLine("\n\n Press any key to exit.");
            Console.ReadLine();
        }
    }
}
