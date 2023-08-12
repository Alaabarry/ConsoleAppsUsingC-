using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class TwentyOneGame : Game, IwalkAway
    {  
        public TwentyOneDealer dealer { get; set; }
        public override void Play() {

            dealer = new TwentyOneDealer();
            foreach (Player player in Players) {
                player.Hand = new List<Card>(); 
                player.stay = false; 

            } 
            dealer.Hand = new List<Card>();
            dealer.stay = false; 
            dealer.deck= new Decks();
            Console.WriteLine("Place your bet ?"); 
            foreach (Player player in Players)
            {

                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet); 
                if (!successfullyBet) {
                    return;
                
                }
                Bets[player] = bet;
            }


        }
        public override void listPlayers()

        {
            Console.WriteLine("21 players ");
            base.listPlayers();
        }
        

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
