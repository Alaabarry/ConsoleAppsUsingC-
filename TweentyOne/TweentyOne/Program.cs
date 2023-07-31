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
            Game game = new Game();
            game.Players = new List<string> { "Alaa", "bill", "Micheal" };
            game.listPlayers();
            Console.ReadLine();

            //create object from class Decks
            //Decks deck = new Decks(); 
          //  deck.Shuffle(3); 
           
           // foreach (Card card in deck.Cards)
           // {

           //     Console.WriteLine(card.Face + "of" + card.Suit);

          //  }

          //  Console.WriteLine(deck.Cards.Count); 
            
        }
        
       
        
        
    }
}
