using Labb_2___API___Angular.Models;
using Labb_2___API___Angular.Models.Interfaces;

namespace Labb_2___API___Angular.Repositories
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly AppDbContext _context;
        public DepartmentRepo(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public Department GetById(int id)
        {
            return _context.Departments.FirstOrDefault(e => e.ID == id);
        }

        public Department AddDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return department;
        }

        public Department DeleteDepartment(int id)
        {
           Department depToDelete = _context.Departments.FirstOrDefault(e => e.ID == id);
            if (depToDelete != null)
            {
                _context.Remove(depToDelete);
                _context.SaveChanges();
                return depToDelete;
            }
            return null;
        }

        public Department UpdateDepartment(Department department, int id)
        {
            Department depToUpdate = _context.Departments.FirstOrDefault(e => e.ID == id);
            if (depToUpdate != null)
            {
                depToUpdate.DepartmentName = department.DepartmentName;
                _context.SaveChanges();
                return depToUpdate;
            }
            return null;
        }
    }
}
