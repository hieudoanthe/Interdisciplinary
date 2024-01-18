using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace QL_2HM.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required]
        public DateTime OrderDate {  get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
