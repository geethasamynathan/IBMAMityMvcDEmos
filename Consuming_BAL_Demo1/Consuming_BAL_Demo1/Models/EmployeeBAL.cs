using System;
using System.Collections.Generic;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Text;
using Consuming_BAL_Demo1.Models;
namespace Consuming_BAL_Demo1

{
 public class EmployeeBAL
    {
       
        public List<Employee> GetAllEmployees()
        {
            string connectionstring =WebConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            List<Employee> employees = new List<Employee>();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Employee employee = new Employee();
                    employee.Empid = Convert.ToInt32(dr["Empid"]);
                    employee.Name = dr["Name"].ToString();
                    employee.Gender = dr["Gender"].ToString();
                    employee.City = dr["city"].ToString();
                    employee.Salary = Convert.ToInt32(dr["Salary"]);
                    employees.Add(employee);
                }
            }
            return employees;

        }
        public Employee getEmployeeById(int id)
        {
            Employee employee = new Employee();
            string connectionstring = WebConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            List<Employee> employees = new List<Employee>();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployeeById", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.Add("@id", id);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   
                    employee.Empid = Convert.ToInt32(dr["Empid"]);
                    employee.Name = dr["Name"].ToString();
                    employee.Gender = dr["Gender"].ToString();
                    employee.City = dr["city"].ToString();
                    employee.Salary = Convert.ToInt32(dr["Salary"]);
                    
                }
            }
           
            return employee;
        }
        public string AddNewEmployee(Employee emp)
        {
            string message;
            Employee employee = new Employee();
            string connectionstring = WebConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            List<Employee> employees = new List<Employee>();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("spNewEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", emp.Name);
                cmd.Parameters.AddWithValue("@gender", emp.Gender);
                cmd.Parameters.AddWithValue("@city", emp.City);
                cmd.Parameters.AddWithValue("@salary", emp.Salary);
                con.Open();
                int rowcount = cmd.ExecuteNonQuery();
                if(rowcount>0)
                {
                    message = "Record inserted successfully";
                }
                else
                {
                    message = "soory! Record  Not inserted successfully";
                }
            }
            return message;
        }
        public string UpdateEmployee(Employee emp)
        {
            string message;
            Employee employee = new Employee();
            string connectionstring = WebConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            List<Employee> employees = new List<Employee>();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("spNewEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", emp.Name);
                cmd.Parameters.AddWithValue("@gender", emp.Gender);
                cmd.Parameters.AddWithValue("@city", emp.City);
                cmd.Parameters.AddWithValue("@salary", emp.Salary);
                con.Open();
                int rowcount = cmd.ExecuteNonQuery();
                if (rowcount > 0)
                {
                    message = "Record updated successfully";
                }
                else
                {
                    message = "soory! Record  Not updated successfully";
                }
            }
            return message;
        }
    }
}
