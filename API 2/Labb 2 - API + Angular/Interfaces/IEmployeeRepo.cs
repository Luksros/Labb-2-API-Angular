namespace Labb_2___API___Angular.Models.Interfaces
{
    public interface IEmployeeRepo
    {
        public IEnumerable<Employee> GetAll();
        public Employee GetById(int id);
        public Employee AddEmployee(Employee employee); 
        public Employee UpdateEmployee(Employee employee, int id);
        public Employee DeleteEmployee(int id);
    }
}
