using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{ 
    //create class employee that contain three properties id,fname,lastname
    public class Employee
    { 

        public int Id { get; set; } 
        public string Firstname { get; set; } 
        public string Lastname { get; set; }

        // create overloading operator method that checks if two object have the same id or not
        public static bool operator ==(Employee emp1, Employee emp2) 
        {
            // check if object emp1 id is equal to object emp2 id
            if (emp1.Id.Equals(emp2.Id)) {
                //if its equal return  true 
                return true;
            } 
            return false;
        
        
        } 
        //create overloading operator method because operator must be in pairs.and check if is not equal 
        public static bool operator !=(Employee emp1, Employee emp2) {

            if (emp1.Id.Equals(emp2.Id)) {

                return true;
            
            }
            return false;
        
        }
    }
}
