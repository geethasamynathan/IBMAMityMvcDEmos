using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmptyMVCDemo1.Models;
using EmptyMVCDemo1.ViewModels;

namespace EmptyMVCDemo1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["id"] = 101;
            ViewData["name"] = "Geetha";

            ViewBag.eid = 102;
            ViewBag.ename = "Fransy";

            EmployeeBusinessLayer employee = new EmployeeBusinessLayer();
            Employee emp = employee.GetEmployeeDetails();
            ViewData["emp1"] = emp;
            ViewBag.Employeeinfo = emp;
            return View();
        }
        /// <summary>
        /// Strongly typed View
        /// </summary>
        /// <returns></returns>
        public ActionResult Index1()
        {
            EmployeeBusinessLayer employee = new EmployeeBusinessLayer();
            Employee emp = employee.GetEmployeeDetails();
            Employee employee1 = new Employee() {
                EmployeeId=1,Name="Manak",Gender="Male",Salary=9000
            };
            Address address = new Address() { City ="Ghaziabhad",State="UP",Country="India"};
            EmployeeDetailViewModel viewModel = new EmployeeDetailViewModel();
            viewModel.Employee = employee1;
            viewModel.Address = address;
            viewModel.pageTitle = "Index1 is My PAge Title";

            return View(viewModel);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}