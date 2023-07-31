using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddEmployeeSimpleApp
{ 
    // create absract class person that contain two properties fname,lastname and method ...
    public abstract class Person
    {  
       
        public string firstName { get; set; } 
        public string lastName { get; set; }

        // create abstract method add Emp ...
        public abstract void AddEmp();
        
     

            
        
        
    }
}
