using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventorySystem.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        [Required]
        [StringLength(25)]
        public String Type { get; set; }

        [Required]
        [StringLength(25)]
        public String Code { get; set; }

        [Required]
        [StringLength(25)]
        public String Size { get; set; }

        [Required]
        [StringLength(25)]
        public String Color { get; set; }

        [Required]
        [MaxLength(12)]
        [MinLength(1)]
        [RegularExpression("[0-9]", ErrorMessage = "Quantity must be numeric")]
        public int Quantity { get; set; }

        [Required]
        [StringLength(255)]
        public String Comment { get; set; }
        
        public Seller Seller { get; set; }

        public int SellerId { get; set; }
    }
}