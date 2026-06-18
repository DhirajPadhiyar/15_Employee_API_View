using _15_Employee_API_View.Models;
using _15_Employee_API_View.Services;
using Microsoft.AspNetCore.Mvc;

namespace _15_Employee_API_View.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesApiController : Controller
    {
        private readonly EmployeeService _service;
        public EmployeesApiController(EmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = _service.GetAllEmployees();
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult InsertEmployee(Employee employee)
        {
            _service.InsertedData(employee);
            return Ok("Employee Inserted Successfully");
        }
    }
}
