using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SqlAdo.Net
{
    public class AdoDotNet
    {
        public void CreateDatabase()
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;database=master; Integrated Security=True";
                string query = @"create Database payroll_service;";
                SqlConnection connetion = new SqlConnection(connectionString);
                connetion.Open();

                SqlCommand command = new SqlCommand(query, connetion);
                int status = command.ExecuteNonQuery();
                if (status == 1)
                    Console.WriteLine("Database Created Successfully");
                connetion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
    }
}
