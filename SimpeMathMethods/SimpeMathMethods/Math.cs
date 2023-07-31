using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimpeMathMethods
{ 
    //Create Class Math make it public to be accessable to other parts of program
   public class Math
    { 
        // public method that execute math operation on two integers
        public void myMath(int numOne, int numTwo) {
            // Int numOne divided by 2 ,numTwo variable to display only
            numOne /= 2; 
            //Output Message of math operation and display NumTwo..
            Console.WriteLine(" 10 Divided By 2 equal = "+numOne +", this Integer onlyfor display "+numTwo);
        
        }

    }
}
