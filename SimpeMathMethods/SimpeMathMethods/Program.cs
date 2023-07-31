using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpeMathMethods
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // create object of class Math
            Math sum = new Math(); 
            //Call Mymath method and Pass Two Arguments to method to execute..
            sum.myMath(numOne : 10 , numTwo :100);  
            //required to do math operation on first number , the second number is only for display.. 
            //Assigned method parameters by Name... 
            Console.ReadLine();
           

        }
    }
}
