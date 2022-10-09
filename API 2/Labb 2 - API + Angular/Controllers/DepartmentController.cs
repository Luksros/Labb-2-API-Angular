using Labb_2___API___Angular.Models;
using Labb_2___API___Angular.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb_2___API___Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public IDepartmentRepo _departments;
        public DepartmentController(IDepartmentRepo departments)
        {
            _departments = departments;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartments()
        {
            var departments = _departments.GetAll();
            return Ok(departments);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            var department = _departments.GetById(id);
            if(department == null)
            {
                return NotFound("Department with this ID could not be found.");
            }
            return Ok(department);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewDepartment(Department department)
        {
            var added = _departments.AddDepartment(department);
            return CreatedAtAction(nameof(GetDepartmentById), new { id = added.ID }, added);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateDepartment(Department department, int id)
        {
            if(id != department.ID)
            {
                return BadRequest();
            }
            var depToUpdate = _departments.GetById(id);
            if (depToUpdate == null)
            {
                return NotFound("Department with this ID could not be found");
            }
            _departments.UpdateDepartment(department, id);
            return Ok(depToUpdate);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var depToDelete = _departments.DeleteDepartment(id);
            if (depToDelete == null)
            {
                return NotFound("Department with this ID could not be found.");
            }
            return Ok(depToDelete);
        }

    }
}
