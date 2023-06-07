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
                string query = @"Select Sum(Salary) as TotalSum,Avg(Salary) As Average,Min(Salary) as MinSalary,Count(Salary)as CountSalary,Max(Salary)as MaxSalary from employee_payroll where Gender='F'";
                SqlConnection connetion = new SqlConnection(connectionString);
                connetion.Open();

                SqlCommand command = new SqlCommand(query, connetion);
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("TotalSum , Average, MinSalary, CountSalary, MaxSalary");
                Console.WriteLine("=============================");

                while (reader.Read())
                {
                   
                    Console.Write(reader["TotalSum"].ToString() + ", ");
                    Console.Write(reader["Average"].ToString() + ", ");
                    Console.Write(reader["MinSalary"].ToString() + ", ");
                    Console.Write(reader["CountSalary"].ToString() + ", ");
                    Console.Write(reader["MaxSalary"].ToString() + ", ");                    
                }
                reader.Close();
                connetion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void SelectGroupBy()
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;database=payroll_service; Integrated Security=True";
                string query = @"SELECT SUM(salary) as TotalSum FROM employee_payroll WHERE gender = 'F' GROUP BY gender;";
                SqlConnection connetion = new SqlConnection(connectionString);
                connetion.Open();

                SqlCommand command = new SqlCommand(query, connetion);
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("TotalSum");
                Console.WriteLine("=============================");

                while (reader.Read())
                {

                    Console.Write(reader["TotalSum"].ToString());
                  
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
