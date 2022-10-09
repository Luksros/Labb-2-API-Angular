using System.ComponentModel.DataAnnotations;

namespace Labb_2___API___Angular.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 2)]
        public string DepartmentName { get; set; }
    }
}
