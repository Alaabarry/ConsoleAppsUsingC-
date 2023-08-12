using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class Card
    {  
       

        public Face Face { get; set; } 
        public Suit Suit { get; set; }
    }

    public enum Suit {
    
    Clubs, 
    Diamonds, 
    Hearts, 
    Spades,
    
    
    
    }
    public enum Face { 
    
     Two, 
     Three, 
     Four, 
     Five, 
     Six, 
     Seven, 
     Eight, 
     Nine, 
     Ten, 
     Jack, 
     Queen, 
     King, 
     Ace,
    
    }

}
