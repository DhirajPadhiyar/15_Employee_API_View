using _15_Employee_API_View.Data;
using _15_Employee_API_View.Models;

namespace _15_Employee_API_View.Services
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _context;
        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }
        public void InsertedData(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
        public Employee? FindId(int id)
        {
            return _context.Employees.Find(id);
        }
    }
}
