using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBrandSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List (strings) of most famous computer brands...
            List<string> ComputerBrands = new List<string>()
            { "Dell", 
              "Asus", 
              "Msi", 
              "Acer", 
              "lenovo", 
              "Gigabyte", 
              "Hp", 
              "Microsoft"
            };
            //Ask the user to provide A computer brand name to search in the list..
            Console.WriteLine("Welcome to computerBrand database enter a brand name..?");

            //Reading User Input...
            string Search = Console.ReadLine();

            //iteration throught the list to find matching text... 

            for (int i = 0; i < ComputerBrands.Count; i++) {
                // store the string which is attached to index[i]in FindItem variable
                string FindItem = ComputerBrands[i];
                // check if user input matched with item on the list
                if (Search == FindItem)
                {
                    Console.WriteLine("your computer brand is found : " + FindItem);
                    break;

                }
                else {
                    Console.WriteLine("Searching..your item is not on the list"); 
                    
                
                
                }

               




            }
            
                
            
            
            
            
            
            
            
            
            
            
           
            




     
        
        }
    
    
    
    
    
    }



}
