using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        ///////////////PART 1
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





        ///////////////////// PART 2 infinite loops
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







        ////////////////////////// PART 3

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





        //////////////////PART 4

        //List<string> cars = new List<string>() { "Taurus", "Corolla", "Tesla", "4x4", "Charger" };
        //Console.WriteLine("what's one of your favorite cars?");
        //string carGuess = Console.ReadLine();
        //bool cars2 = false;

        //for (int i = 0; i < cars.Count; i++)
        //{
        //    if (carGuess == cars[i])
        //    {
        //        cars2 = true;
        //        Console.WriteLine("your car is number " + i + " on our list");
        //    }
        //}
        //if (cars2 == false)
        //{

        //    Console.WriteLine("your car isn't on our list");

        //}
        //Console.ReadLine();







        ///////////////////PART 5

        //List<string> cars1 = new List<string>() { "Taurus", "Corolla", "Tesla", "4x4", "Charger", "Corolla" };
       
        //foreach (string car in cars1)
        //{
        //    Console.WriteLine(car);
        //}
        //Console.ReadLine();

        //Console.WriteLine("select a car in the list");
        //string userInput = Console.ReadLine();
        //bool notInList = true;

        //for (int i = 0; i < cars1.Count; i++)

        //{
        //    if (userInput == cars1[i]) 
        //    {
        //        notInList = false;
        //        Console.WriteLine(i);
        //    }
        //}
        //if (notInList == true)
        //{
        //    Console.WriteLine("NOT in list");
        //}
        //Console.ReadLine();



        //////////////PART 6


        //List<string> foods = new List<string>() { "Tomatoes", "Corn", "Tortilla", "Pico", "Guac", "Corn" };
        //List<string> foodsCopy = new List<string>();

        //foreach (var item in foods)
        //{
        //    foreach (var itemCopy in foodsCopy)
        //    {
        //        if (item == itemCopy)
        //        {
        //            Console.WriteLine("This is a duplicate: " + item);
        //        }
        //    }
        //    foodsCopy.Add(item);
        //}   

        
        // Console.ReadLine();























        //for (int i = 0; i < foods.Count; i++)
        //{
        //    if (i >= 1)
        //        Console.WriteLine("This is a duplicate" + foods[i]);
        //    Console.ReadLine();
     

        //int tomatoes = 0, corn = 0, tortilla = 0, pico = 0, guac = 0;
            //if (food == "Tomatoes")
            //    tomatoes++;
            //else if (food == "Corn")
            //    corn++;
            //else if (food == "Tortilla")
            //    tortilla++;
            //else if (food == "Pico")
            //    pico++;
            //else if (food == "Guac")
            //    guac++;


        //for (int i = 0; i < foods.Count; i++)
        //{
        //    if (foods[i] == foods[i])
        //    {
        //        duplicate = true;
        //        Console.WriteLine(foods[i] + " is a duplicate in the list");
        //    }
         
        //}
        //if (duplicate == false) 
        //{
        //    Console.WriteLine("only once in list");
        //}
      



//////////////////////////////////////////////////////////////////////////////////////////////











        /// List<int> passingScores = new List<int>();

        //    foreach (int score in testScores)
        //    {
        //        if (score > 85)
        //        {
        //            passingScores.Add(score);
        //        }
        //    }
        //    Console.WriteLine(passingScores.Count); 
        //    Console.ReadLine();


        //Console.WriteLine("select a car in the list");
        //string userInput = Console.ReadLine();
        //bool notInList = true;

        //for (int i = 0; i < cars1.Count; i++)

        //{
        //    if (userInput == cars1[i])
        //    {
        //        notInList = false;
        //        Console.WriteLine(i);
        //    }
        //}
        //if (notInList == true)
        //{
        //    Console.WriteLine("NOT in list");
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

