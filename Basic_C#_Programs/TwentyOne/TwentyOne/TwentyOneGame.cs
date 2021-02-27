using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach(Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay - false;
            Dealer.Deck = new Deck();
            
            Console.WriteLine("Place your bet");

            foreach(Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Player)
                {
                    Console.Write("{0}:", player.Name);
                    Dealer.Deal(player.Hand);
                    bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                            {
                            Console.WriteLine("blackjack! {0} wins {1},", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) = Bets[player]);
                            
                            return;
                            }
                    
                }
                
                Console.Write("dealer");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has blackjack!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                    }
                }
            //throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
