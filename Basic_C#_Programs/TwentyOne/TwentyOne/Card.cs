﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        //constructor
        public Card()
        {
            suit = "Spades";
            face = "Two";
        }
        public string suit { get; set; }
        public string face { get; set; }
    }
}