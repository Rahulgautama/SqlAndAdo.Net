using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SqlAdo.Net
{
    public class AdoDotNet
    {
        public void Select()
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;database=payroll_service; Integrated Security=True";
                string query = @"Select * from employee_payroll where Salary>1000 and Salary<2500";
                SqlConnection connetion = new SqlConnection(connectionString);
                connetion.Open();

                SqlCommand command = new SqlCommand(query, connetion);
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("Id , Name," + "  Salary , Date");
                Console.WriteLine("=============================");

                while (reader.Read())
                {
                    Console.Write(reader["Id"].ToString() + ", ");
                    Console.Write(reader["Name"].ToString() + ", ");
                    Console.Write(reader["Salary"].ToString() + ", ");
                    Console.WriteLine(reader["StartDate"].ToString() + ", ");
                }
                reader.Close();
                connetion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
