using Labb_2___API___Angular.Models;
using Labb_2___API___Angular.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Labb_2___API___Angular.Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly AppDbContext _context;
        public EmployeeRepo(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.Include(e => e.Department).Include(e => e.Gender).ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.Include(e => e.Department).Include(e => e.Gender).FirstOrDefault(e => e.ID == id);
        }

        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChangesAsync();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employeeToDelete = _context.Employees.FirstOrDefault(e => e.ID == id);
            if(employeeToDelete != null)
            {
                _context.Employees.Remove(employeeToDelete);
                _context.SaveChanges();
                return employeeToDelete;
            }
            return null;
        }

        public Employee UpdateEmployee(Employee employee, int id)
        {
            Employee employeeToUpdate = _context.Employees.FirstOrDefault(e => e.ID == id);
            if(employeeToUpdate != null)
            {
                employeeToUpdate.FirstName = employee.FirstName;
                employeeToUpdate.LastName = employee.LastName;
                employeeToUpdate.DepartmentID = employee.DepartmentID;
                employeeToUpdate.GenderID = employee.GenderID;
                employeeToUpdate.Salary = employee.Salary;
                employeeToUpdate.Address = employee.Address;
                employeeToUpdate.Title = employee.Title;
                _context.SaveChanges();
                return employeeToUpdate;
            }
            return null;
        }
    }
}
