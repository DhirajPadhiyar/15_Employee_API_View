using _15_Employee_API_View.Models;
using _15_Employee_API_View.Services;
using Microsoft.AspNetCore.Mvc;

namespace _15_Employee_API_View.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeService _service;
        public EmployeesController(EmployeeService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var employees = _service.GetAllEmployees();
            return View(employees);
        }
        public IActionResult InsertData()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertData(Employee employee)
        {
           if(!ModelState.IsValid)
            {
                return View(employee);
            }

            _service.InsertedData(employee);
            return RedirectToAction("Index");
        }
    }
}