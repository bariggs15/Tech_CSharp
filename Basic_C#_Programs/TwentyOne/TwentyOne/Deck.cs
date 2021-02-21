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
            Card cardOne = new Card();
            cardOne.face = "Two";
            cardOne.suit = "Hearts";
            Cards.Add(cardOne);
        }
        public List<Card> Cards { get; set; }
    }
}
