using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public abstract class Game 

    { 
        public List<string> Players { get; set; } 
        public string Name { get; set; }     
        public string Dealer { get; set;  }
        public abstract void Play();
        public virtual void listPlayers() {
            foreach (string player in Players) { 
            Console.WriteLine(player);
            
            }
        
        }


    }
}
