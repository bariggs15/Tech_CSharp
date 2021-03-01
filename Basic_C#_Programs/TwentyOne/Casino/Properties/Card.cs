using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card
    {
        public Suit suit { get; set; }
        public Face face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", face, suit);
        }
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
