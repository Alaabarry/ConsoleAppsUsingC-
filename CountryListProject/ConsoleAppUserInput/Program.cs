using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUserInput
{
    internal class Program
    {
        static void Main(string[] args)

        {   //initialize an array of strings with length of 10 index.
            string[] MyArray = new string[10];

            Console.WriteLine("pls provide ten Country names..?");
            //using for loop to insert User Input(strings) into Array
            for (int i=0; i< MyArray.Length;i++ ) {
                MyArray[i]=Console.ReadLine();
                
             
            
            }
            Console.WriteLine("Countries List...");
            // using foreach to display all the strings of Array
            foreach ( string y in MyArray) { 

            Console.WriteLine("...............");    
            Console.WriteLine(""+y);
            
            }
            Console.WriteLine("thank you for Answering..");
            Console.ReadLine();
           
                
            
           
           

        }
    }
}
