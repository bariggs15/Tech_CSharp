using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {

        //string[] family = { "Dad", "Mom", "Brother", "Sister" };
        //Console.WriteLine("What other family is there?");
        //string newFam = Console.ReadLine();

        //for (int i = 0; i < family.Length; i++)
        //{
        //    family[i] += newFam;
        //}
        //for (int i = 0; i < family.Length; i++)
        //{
        //    Console.WriteLine(family[i]);
        //}

        //Console.ReadLine();

        /////////////////////infinite loops
        //for (int i = 0; i < 100; i--)
        //    {
        //        Console.WriteLine("number : {0}", i);
        //    }
        //Console.ReadLine();

        //for (int i = 0; i < 100; i++)
        //{
        //    Console.WriteLine("number : {0}", i);
        //}
        //Console.ReadLine();


        //int[] golfScore = { 65, 12, 32, 14, 80, 62, 100, 30 };

        //for (int i = 0; i < golfScore.Length; i++)
        //{
        //    if (golfScore[i] < 60)
        //    {
        //        Console.WriteLine("What's a good score in golf:" + golfScore[i]);
        //    }

        //}
        //Console.ReadLine();

        //int[] golfScore = { 65, 12, 32, 14, 80, 62, 100, 30 };

        //for (int i = 0; i < golfScore.Length; i++)
        //{
        //    if (golfScore[i] <= 60)
        //    {
        //        Console.WriteLine("What's a good score in golf:" + golfScore[i]);
        //    }

        //}
        //Console.ReadLine();


        List<string> cars = new List<string>() { "Taurus", "Corolla", "Tesla", "4x4", "Charger" };
        Console.WriteLine("what's one of your favorite cars?");
        string carGuess = Console.ReadLine();

        for (int i = 0; i < cars.Count; i++)
        {
            if (carGuess == cars[i])
            {
                Console.WriteLine(cars[i] + " is on our list");
            }
            else
            {
                Console.WriteLine("your car isn't on our list");

            }
        }
        Console.ReadLine();


        //List<string> cars1 = new List<string>() { "Taurus", "Corolla", "Tesla", "4x4", "Charger", "Corolla" };
        //Console.WriteLine(cars1[i]);
        //Console.WriteLine("select a car in the list");
        //Console.ReadLine();






        //List<string> names = new List<string>() { "Austin", "Bob", "Charles" };

        //    foreach (string name in names)
        //    {

        //        Console.WriteLine(name);    

        //    }

        //    Console.ReadLine();

        //    List<int> testScores = new List<int>() { 92, 100, 75, 45, 34 };
        //    List<int> passingScores = new List<int>();

        //    foreach (int score in testScores)
        //    {
        //        if (score > 85)
        //        {
        //            passingScores.Add(score);
        //        }
        //    }
        //    Console.WriteLine(passingScores.Count);
        //    Console.ReadLine();

















        //    int[] testScores = { 99, 98, 85, 64, 30, 12, 100, 35 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score:" + testScores[i]);
        //    }

        //}
        //Console.ReadLine();

        //string[] names = { "Austin", "Bob", "Charles" };

        //for(int j = 0; j < names.Length; j++)
        //{
        //    if (names[j] == "Bob")
        //    {
        //        Console.WriteLine(names[j]);
        //    }
        //    Console.ReadLine();

        //   string[] names = { "Austin", "Bob", "Charles" };

        //   for (int j = 0; j < names.Length; j++)
        //   {

        //       {
        //           Console.WriteLine(names[j]);
        //       }
        //   }   
        //Console.ReadLine();


        //    List<int> testScores = new List<int>();
        //    testScores.Add(98);
        //    testScores.Add(99);
        //    testScores.Add(58);
        //    testScores.Add(19);
        //    testScores.Add(89);
        //    testScores.Add(35);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score:" + score);
        //    }
        //}
        //Console.ReadLine();



        //List<string> names = new List<string>() { "Austin", "Bob", "Charles" };

        //    foreach (string name in names)
        //    {

        //        Console.WriteLine(name);    

        //    }

        //    Console.ReadLine();

        //    List<int> testScores = new List<int>() { 92, 100, 75, 45, 34 };
        //    List<int> passingScores = new List<int>();

        //    foreach (int score in testScores)
        //    {
        //        if (score > 85)
        //        {
        //            passingScores.Add(score);
        //        }
        //    }
        //    Console.WriteLine(passingScores.Count);
        //    Console.ReadLine();
    }

}

