using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmptyMVCDemo1.Models
{
    public class EmployeeBusinessLayer
    {
        public Employee GetEmployeeDetails()
        {

            Employee employee = new Employee()

            {
                EmployeeId = 101,
                Name = "Geetha",
                Gender = "Female",
                Address = "CBE",
                City = "TUP",
                Salary = 9000
            };
            

            return employee;
        }
    }
}