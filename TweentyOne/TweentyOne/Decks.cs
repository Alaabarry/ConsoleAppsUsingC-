using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class Decks
    {
        public List<Card> Cards = new List<Card>();
        public Decks() {
            // Create an empty List that will contain values after object assign values to it
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++) {

                for (int j = 0; j < 4; j++) { 
                Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);    
                
                
                }
            
            }
               
            
            }

         
        //end of constructer class

     

        public void Shuffle(int Times=1) {

            for (int i=0; i< Times; i++) 
            
            {
             List<Card>Templist = new List<Card>(); 
             Random rnd = new Random(); 

                while (Cards.Count > 0) {
                int randomIndex = rnd.Next(0,Cards.Count);
                    Templist.Add(Cards[randomIndex]);
                    Cards.Remove(Cards[randomIndex]); 

                
                
                }
                Cards = Templist;
            
            
            
            
            }
        
        
        
        }
       
            

        }
    }

