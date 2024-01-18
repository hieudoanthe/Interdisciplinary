using System.ComponentModel.DataAnnotations;
namespace QL_2HM.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        private string? PassWord { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
