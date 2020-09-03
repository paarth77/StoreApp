using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    // Model class representing table->Orders
    public class Orders
    {
        // Unique Identity for table Orders
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        // Foreign Keys
        [ForeignKey("Customers")]
        public int CustomerId { get; set; }
        public Customers Customer { get; set; }
        // Ordered Date
        public DateTime OrderDate { get; set; }
        // List of OrderITems for Orders-OrderItem relationship
        public List<OrderItem> OrderItem { get; set; }
        // Default Constructor
        public Orders()
        {
            OrderItem = new List<OrderItem>();
        }
    }
}
