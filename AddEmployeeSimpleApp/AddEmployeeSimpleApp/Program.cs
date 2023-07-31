using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddEmployeeSimpleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {    // create objec Emp from class employee and assign fname and last name that inherit from person class
            Employee empOne = new Employee() { firstName ="Alaa", lastName = "Barry"}; 
            //call the superclass method addEmp  on employee object...
            empOne.AddEmp(); 
            //call the superclass method Quiet on employee object...
            empOne.Quiet();
            Console.ReadLine();
        }
    }
}
