using Labb_2___API___Angular.Models;
using Labb_2___API___Angular.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb_2___API___Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public IEmployeeRepo _employees;
        public EmployeesController(IEmployeeRepo employees)
        {
            this._employees = employees;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = _employees.GetAll();
            return Ok(employees);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = _employees.GetById(id);
            if(employee == null)
            {
                return NotFound("Employee with this ID could not be found.");
            }
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            if (employee == null) { return BadRequest(); }
            var added = _employees.AddEmployee(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = added.ID }, added);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateEmployee(Employee employee, int id)
        {
            if (employee.ID != id)
            {
                return BadRequest();
            }
            var empToUpdate = _employees.GetById(id);
            if(empToUpdate == null)
            {
                return NotFound("Employee with this ID could not be found.");
            }
            _employees.UpdateEmployee(employee, id);
            return Ok(empToUpdate);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
           var empToDel = _employees.DeleteEmployee(id);
            if (empToDel != null)
            {
                return Ok(empToDel);
            }
            return NotFound("Employee with this ID could not be found.");
        }
    }
}
