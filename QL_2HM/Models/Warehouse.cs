using System;
using System.ComponentModel.DataAnnotations;

namespace QL_2HM.Models
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }
        [Required]
        public string? Name { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
