using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddEmployeeSimpleApp
{ 
    // create class person that contain two properties fname,lastname, method to display full name...
    public class Person
    {  
       
        public string firstName { get; set; } 
        public string lastName { get; set; }
         
        // create void method that takes no parameters and write to console emp full name..
        public void AddEmp() {

            Console.WriteLine("Employee Full Name is " + this.firstName + this.lastName);
        
        }
    }
}
