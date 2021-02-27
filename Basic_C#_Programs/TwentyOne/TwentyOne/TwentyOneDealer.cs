using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class TwentyOneDealer : Dealer

    {
        List<Card> Hand { get; set; }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
