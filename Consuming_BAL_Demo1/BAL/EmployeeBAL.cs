﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace BAL
{
 public   class EmployeeBAL
    {
        public List<Employee> GetEmployees()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
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
    }
}
