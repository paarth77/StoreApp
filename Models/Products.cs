using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    // Model class representing table->Products
    public class Products
    {
        // unique identity for table Products
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        // Name of the Product
        public string  Name { get; set; }
        // Description of the Product
        public string Description { get; set; }
        // OrderITem and Products Relationship
        public List<OrderItem> OrderItem { get; set; }
        //Default constructor
        public Products()
        {
            OrderItem = new List<OrderItem>();
        }
    }
}
