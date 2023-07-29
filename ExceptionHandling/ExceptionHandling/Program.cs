using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)


        {
            try
            {
                Console.WriteLine("Pick a number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dividing two numbers");
                int num3 = num1 / num2;
                Console.WriteLine(num1 + "  divided by  " + num2 + " equal " + num3);
            }
            catch (FormatException ex) {

                Console.WriteLine(ex.Message);
                return;


            }
            catch (DivideByZeroException ex) {
                Console.WriteLine("Please dont divide by zero");
            
            }
            finally{

                Console.ReadLine();
            }

        }
    }
}
