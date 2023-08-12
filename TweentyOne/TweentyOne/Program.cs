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
            Console.WriteLine("Welcome to Los Angelos Hotel and casino..Let's start by telling me your name .?"); 
             
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today"); 

            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}, Would you like to join 21 game right now.? ", playerName);

            string answer = Console.ReadLine().ToLower() ;

            if (answer =="Ya"|| answer =="yes" || answer =="y") {
            
              Player player = new Player(bank,playerName);
                Game game = new TwentyOneGame();
                game += player; 
                player.IsActivePlaying = true;
                while (player.IsActivePlaying && player.Balance > 0) { 

                game.Play();
                
                } 
                game -= player;
                Console.WriteLine("thank you for playing ...");
                Console.WriteLine("Feel free to look around the casino Bye for now..");
                Console.Read();
            
            }






        }
    }
}
