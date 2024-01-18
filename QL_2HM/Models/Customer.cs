using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QL_2HM.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string? FirtName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        private string? Password { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
