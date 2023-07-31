using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
   public class Dealer 
    { 
        public string Name { get; set; } 
        public Decks deck { get; set; } 
        public int Balance { get; set; }

        public void Deel(List<Card> Hand) {

            Hand.Add(deck.Cards.First());
            Console.WriteLine(deck.Cards.First().ToString()+ "/n");
            deck.Cards.RemoveAt(0);
        
        }
    }
}
