using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            //create object emp1 from class employee and pass values to object properties
           Employee emp1 = new Employee(); 
            emp1.Id = 1; 
            emp1.Firstname = "Joe";
            emp1.Lastname = " Jones"; 
            // create object emp 2 and pass values
            Employee emp2 = new Employee(); 
            emp2.Id = 1;
            emp2.Firstname = "Joe";
            emp2.Lastname = "Jones";
            // check if objects are equal 
            if (emp1 == emp2) 
            {

                Console.WriteLine(" emp1 is equal to emp2 based on Id propertie");
            
            
            }  
            // not equal case..
            else
            {

                Console.WriteLine("emp1 is not equal to emp2 based on Id propertie");
            }

            Console.ReadLine();
            
        }
    }
}
