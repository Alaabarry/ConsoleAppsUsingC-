using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Program Gui to interact with user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //asking user to provide package weight
            Console.WriteLine("please enter the package weight :");
            // getting user input(value) and convert it from string to integer
            string getWeight = Console.ReadLine();
            int totalWeight = Convert.ToInt32(getWeight);
            //using if condition to see if the weight is bigger than 50 display error messeage
            if (totalWeight > 50)
            {

                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

            }


            //asking user to provide package width
            Console.WriteLine("please enter the package width :");
            //getting package width from the user
            string getWidth = Console.ReadLine();
            int totalWidth = Convert.ToInt32(getWidth);
            //asking user to provide package height
            Console.WriteLine("please enter the package height");

            string getHeight = Console.ReadLine();
            int totalHeight = Convert.ToInt32(getHeight);
            //asking user to provide package lenght
            Console.WriteLine("please enter the package length");

            string getLength = Console.ReadLine();
            int totatLength = Convert.ToInt32(getLength);

            // check package dimensions total if greater than 50,
            if (totalWidth + totalHeight + totatLength > 50)
            {

                Console.WriteLine("Package too big to be shipped via Package Express .");

            }
            else
            {
                //calculate shipping price passed on height,width,length and weight of the package
                int total_Shipping = (totalHeight * totalWidth * totatLength) * totalWeight / 100;

                decimal shipping_Cost = Convert.ToDecimal(total_Shipping);
                // display to user shipping cost of the package..
                Console.WriteLine("Your estimated total for shipping this package is : $" + shipping_Cost);
                Console.WriteLine("Thank you !");

            }



        }
    }
}
