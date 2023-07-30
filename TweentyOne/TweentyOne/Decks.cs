using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class Decks
    {
        public Decks() {
            // Create an empty List that will contain values after object assign values to it
            Cards = new List<Card>(); 
            // List of strings contain(card faces)
            List<string> Faces = new List<string>() { "Spades", "Diamond","Hearts","Clubs" };
            //Creating a list of string that contain(card suites)
            List<string> Suites = new List<string>()
            {"Two","Three","Four","Five","Six","Seven","Eight","Nine",
              "Ten","Jack","Queen","King","Ace"
            };
            //loop through two lists to Asign properties of the card = values
            foreach (string face in Faces) {
                foreach (string suit in Suites) {
                 
                    Card card = new Card(); 
                    card.Suit = suit; 
                    card.Face = face;  
                    //Adding object card that contain Assinged properties to Cards List
                    Cards.Add(card);
                
                
                }
            
            }

        }

        public List<Card>Cards = new List<Card>();
    }
}
