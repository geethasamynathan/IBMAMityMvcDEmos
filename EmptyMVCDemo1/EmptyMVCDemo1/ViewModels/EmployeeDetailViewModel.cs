using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmptyMVCDemo1.Models;

namespace EmptyMVCDemo1.ViewModels
{
    public class EmployeeDetailViewModel
    {
        public Employee Employee { get; set; }
        public Address Address { get; set; }
        public string pageTitle { get; set; }
    }
}