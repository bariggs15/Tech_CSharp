using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            for (int i = 0; i<13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.face = (Face)i;
                    card.suit = (Suit)j;
                    Cards.Add(card);
                }
            }


        }
        public List<Card> Cards { get; set; }


        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while(Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }


        //List<string> suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
        //List<string> faces = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

        //foreach (string face in faces)
        //{
        //    foreach (string suit in suits)
        //    {
        //        Card card = new Card();
        //        card.suit = suit;
        //        card.face = face;
        //        Cards.Add(card);
        //    }
        //}



        ////public /*static*/ Deck Shuffle(/*Deck deck/*, out int timesShuffled*/ int times = 1)
        //public void Shuffle(int times = 1)
        //{
        //    //timesShuffled = 0;
        //    for (int i = 0; i < times; i++)
        //    {
        //        //timesShuffled++;
        //        List<Card> TempList = new List<Card>();
        //        Random random = new Random();

        //        while (/*deck.*/Cards.Count > 0)
        //        {
        //            int randomIndex = random.Next(0, /*deck.*/Cards.Count);
        //            TempList.Add(/*deck.*/Cards[randomIndex]);
        //            /*deck.*/Cards.RemoveAt(randomIndex);
        //        }
        //        /*deck.*/Cards = TempList;
        //    }

        //    //return deck;
        //}
    }
}


            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.face = "Two";
            //cardOne.suit = "Hearts";
            //Cards.Add(cardOne);