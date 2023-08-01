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
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Alaa";
           game = game + player;
            game = game - player;
            Console.ReadLine();
            
           
           Decks deck = new Decks(); 
         deck.Shuffle(3); 
           
            foreach (Card card in deck.Cards)
         {
       
          }

            Console.WriteLine(deck.Cards.Count); 
            
        }
        
       
        
        
    }
}
