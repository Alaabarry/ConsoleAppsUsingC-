using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStudentDB
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var db = new SchoolContext())
            {
                var stud = new Student()
                {
                    StudentName = "Joe", 
                    
                };
                db.Students.Add(stud);
                db.SaveChanges();
            }
        }
    }
}
