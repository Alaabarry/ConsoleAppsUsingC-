using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Data;

namespace SqlserverAndc_
{
     class Program
    {

        static void Main(string[] args)
        {
            employee emp = new employee(); 
            emp.name = "Test"; 
            emp.email = "Test";
            emp.location = "test";

           
        }
        private static void connectiondb(employee emp) {

            string connection = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=employee;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            string querystring = @"INSERT INTO employee(name,emailAdress,location)
                                   VALUES(@name,@emailAdress,@location)" 
                ;

            using (SqlConnection Connection = new SqlConnection(connection)) {
                Connection.Open();

                SqlCommand command = new SqlCommand(querystring, Connection);
                command.Parameters.Add("@name",System.Data.SqlDbType.VarChar,50);
                command.Parameters.Add("@emailAdress", System.Data.SqlDbType.VarChar,50);
                command.Parameters.Add("@location", System.Data.SqlDbType.VarChar, 50);
                command.Parameters["@name"].Value = emp.name;
                command.Parameters["@emailAdress"].Value= emp.email;
                command.Parameters["@location"].Value=emp.location; 
               
                command.ExecuteNonQuery(); 
                Connection.Close();
            
            
            }
            
            
            
            }

        
    }
}
