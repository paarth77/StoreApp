using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    // Model class representing table->Customers
    public class Customers
    {
      
        // Unique Id for table Customer
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        // A Field for Name of the Customer
        public string CustomerName { get; set; }
        // A Field for Phone of the Customer
        public string  Phone { get; set; }
        // A Field for Richness of the Customer
        public bool IsRich { get; set; }
        // A List for Orders-Customer Relationship
        public List<Orders> Orders { get; set; }
        // Defualt Constructor
        public Customers()
        {
            Orders = new List<Orders>();
        }

    }
}
