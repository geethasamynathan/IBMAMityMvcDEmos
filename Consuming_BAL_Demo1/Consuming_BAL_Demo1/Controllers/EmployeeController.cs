using Consuming_BAL_Demo1.Models;
using System.Web.Mvc;
namespace Consuming_BAL_Demo1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeBAL empl = new EmployeeBAL();
            return View(empl.GetAllEmployees());
        }
        [HttpGet]
        public ActionResult Create()
        {
            EmployeeBAL empl = new EmployeeBAL();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            EmployeeBAL empl = new EmployeeBAL();
           string result= empl.AddNewEmployee(employee);
           return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            EmployeeBAL empl = new EmployeeBAL();
            Employee emp= empl.getEmployeeById(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            EmployeeBAL empl = new EmployeeBAL();
            return View();
        }
        public ActionResult Details()
        {
            EmployeeBAL empl = new EmployeeBAL();
            return View();
        }
    }
}