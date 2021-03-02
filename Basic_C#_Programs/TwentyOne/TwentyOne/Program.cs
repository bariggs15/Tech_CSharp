using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //with new constructor
            //Player newPlayer = new Player("Austin");
            const string casinoName = "Grand Hotel and Casino";
         

            Console.WriteLine("Welcome to the {0}. What is your name?",  casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("please enter digits only, no decimals");
            }

            

            Console.WriteLine("Hello {0}, would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\arigg\Logs\log.text", true))
                {
                    file.WriteLine(player.Id);
                    ;
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("an error occurred, please contact your system administrator");
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thanks for playing");
            }
            Console.WriteLine("Feel free to look around casino. Thanks for playing");
            Console.ReadLine();

        }
    }
}


//Deck deck = new Deck();

////deck.Shuffle(3);

////foreach (Card card in deck.Cards)
////{
////    Console.WriteLine(card.face + " of " + card.suit);
////}
////Console.WriteLine(deck.Cards.Count);
//Console.ReadLine();

//DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
//DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 32, 45);

//TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;


////int count = deck.Cards.Count(x => x.face == Face.Ace);
////Console.WriteLine(count);

////List<Card> newList = deck.Cards.Where(x => x.face == Face.King).ToList();

//List<int> numberList = new List<int>() { 1, 2, 45, 6, 57, 23423, };
////int sum = numberList.Sum(x => x + 5);
////int sum = numberList.Max();
//int sum = numberList.Where(x=> x < 50).Sum();


//Console.WriteLine(sum);



//Card card = new Card();
//card.suit = Suit.Clubs;

//Card card1 = new Card();
//Card card2 = card1;
//card1.face = Face.Eight;
//card2.face = Face.King;

//Console.WriteLine(card1.face);
//Game game = new TwentyOneGame();
///*TwentyOneGame game = new TwentyOneGame(*/);
//game.Players = new List<Player>();
////game.Players = new List<Player>() { "Austin", "Bob", "Joe" };
////game.ListPlayers();
//////game.Play();
////Console.ReadLine();

//Player player = new Player();
//player.Name = "Austin";
//game = game + player;
//game = game - player;




////Game game = new Game();
//List<Game> games = new List<Game>();
//Game game = new TwentyOneGame();
//games.Add(game);

//
//    Deck deck = new Deck();
//    //int timesShuffled = 0;
//    //deck.Shuffle(/*deck: deck, out timesShuffled, times: */3);
//    //deck = Shuffle(deck, 3);
//    deck.Shuffle(3);


//    foreach (Card card in deck.Cards)
//    {
//        Console.WriteLine(card.face + " of " + card.suit);

//    }
//    Console.WriteLine(deck.Cards.Count);
//    //Console.WriteLine("times shuffled {0}", timesShuffled);
//    Console.ReadLine();
//


//public static Deck Shuffle(Deck deck, int times)
//{
//    for (int i = 0; i < times; i++) 
//    {
//        deck = Shuffle(deck);
//    }
//    return deck;

//deck.Cards = new List<Card>();



//Card cardOne = new Card();
//cardOne.face = "Queen";
//cardOne.suit = "Spades";

//deck.Cards.Add(cardOne);

//Console.WriteLine(cardOne.face + " of " + cardOne.suit);