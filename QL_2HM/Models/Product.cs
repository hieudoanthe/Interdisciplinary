using System.ComponentModel.DataAnnotations;

namespace QL_2HM.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string? Size {  get; set; }
        [Required]
        public string? Color { get; set; }
        public string? Description { get; set; }
     //   public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
