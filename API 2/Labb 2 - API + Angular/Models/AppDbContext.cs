using Microsoft.EntityFrameworkCore;

namespace Labb_2___API___Angular.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Employee> Employees { get; set; }        
    }
}
