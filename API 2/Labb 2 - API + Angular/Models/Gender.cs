using System.ComponentModel.DataAnnotations;

namespace Labb_2___API___Angular.Models
{
    public class Gender
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string GenderName { get; set; }
    }
}
