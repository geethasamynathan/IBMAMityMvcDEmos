using System;

namespace EmployeeBusinessLayer
{/// <summary>
/// Employee class to communicate with EF DB First Approach. This application is consumed by any other Console or web app
/// </summary>
    public class Employee
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }
    }
}
