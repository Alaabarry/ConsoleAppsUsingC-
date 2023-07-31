using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AddEmployeeSimpleApp
{ 
    // create class employee the inherit from person class, and interface iQuiettable//
    public  class Employee : Person , iQuiettable
    {  
        //create propertie of integer that takes employee id...
        public int Id { get; set; }

       

        //override abstract method add implement to method in employee class 
        public override void AddEmp()
        {
            Console.WriteLine("Employee Full name is " + firstName + lastName);
        }

      
        // call interface method that inherited from interface iQuiettable and display messeage of employee quiet...
        public void Quiet() {

            Console.WriteLine("I Quite my job " + firstName + lastName);
        
        
        }
    }


}
