using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ADM.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User User { get; set; }

        public IList<Product> Product { get; set; }

        [Range(1, 1000)]
        public int? Quantity { get; set; }

        [Required(ErrorMessage = "Price")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }

        public Order()
        {
        }

        public Order(int orderid, User user, Product product, int quantity, decimal price)
        {
            OrderId = orderid;
            User = user;
            Product = (IList<Product>)product;
            Quantity = quantity;
            Price = price;
        }
    }
}
