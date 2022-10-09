namespace Labb_2___API___Angular.Models.Interfaces
{
    public interface IDepartmentRepo
    {
        public IEnumerable<Department> GetAll();
        public Department GetById(int id);
        public Department AddDepartment(Department department); 
        public Department UpdateDepartment(Department department, int id);
        public Department DeleteDepartment(int id);
    }
}
