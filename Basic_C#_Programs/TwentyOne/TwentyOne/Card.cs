using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Suit suit { get; set; }
        public Face face { get; set; }
        
    }        


            
    
    public enum Suit
    {
        Spades,
        Diamonds,
        Clubs,
        Hearts
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
