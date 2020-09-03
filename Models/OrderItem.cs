using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    // Model class representing table->OrderItem
    public class OrderItem
    {
        // Unique Identity for Table OrderItem
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OderItemId { get; set; }
        // Foreign Keys
        [ForeignKey("Orders")]
        public int OrderId { get; set; }
        public Orders Orders { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Products Products { get; set; }
        // Order Quantity
        public int Quantity { get; set; }
    }
}
