using System.ComponentModel.DataAnnotations;

namespace Labb_2___API___Angular.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }

        public string Address { get; set; }
        public string Title { get; set; }
        public decimal Salary { get; set; }

        public int GenderID { get; set; }

        public Gender? Gender { get; set; }

        public int DepartmentID { get; set; }

        public Department? Department { get; set; }

    }
}
