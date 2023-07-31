using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
     class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new TwentyOneGame();
            game.Players= new List<string> { "bill", "omar" };
            game.listPlayers();
            Console.ReadLine();

           
           // Decks deck = new Decks(); 
          //  deck.Shuffle(3); 
           
          //  foreach (Card card in deck.Cards)
          // {
          //     Console.WriteLine(card.Face + "of" + card.Suit);

          //  }

          //  Console.WriteLine(deck.Cards.Count); 
            
        }
        
       
        
        
    }
}
