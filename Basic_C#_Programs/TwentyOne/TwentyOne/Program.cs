using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game game = new Game();
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Austin", "Bob", "Joe" };
            game.ListPlayers();
            game.Play();
            Console.ReadLine();

            //Deck deck = new Deck();
            //deck.Shuffle(3);

        //    foreach(Card card in deck.Cards)
        //    {
        //        Console.WriteLine(card.face + " of " + card.suit);
        //    }
        //    Console.WriteLine(deck.Cards.Count);
        //    Console.ReadLine();
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
        }
    }
}


//deck.Cards = new List<Card>();



            //Card cardOne = new Card();
            //cardOne.face = "Queen";
            //cardOne.suit = "Spades";

            //deck.Cards.Add(cardOne);

            //Console.WriteLine(cardOne.face + " of " + cardOne.suit);