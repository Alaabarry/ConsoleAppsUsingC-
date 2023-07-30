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
            
            //create object from class Decks
            Decks deck = new Decks();
            // deck = Shuffle(deck); 
            deck = Shuffle(deck,3);

            //for loop in decks that containd cards as list
            foreach (Card card in deck.Cards)
            {

                Console.WriteLine(card.Face + "of" + card.Suit);

            }

            Console.WriteLine(deck.Cards.Count); 
            
        }
        public static Decks Shuffle(Decks deck) {
            List<Card> TempList = new List<Card>();
            Random rnd = new Random();
            while(deck.Cards.Count >0){ 
             int randomIndex = rnd.Next(0,deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            
            }
            deck.Cards = TempList; 
            return deck;     
            
        }
        public static Decks Shuffle(Decks deck, int Times) {

            for (int i=0; i< Times;i++)
            {
             deck = Shuffle(deck, i);
            
            } 
            return deck;
        
        }
    }
}
