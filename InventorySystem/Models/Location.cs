using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventorySystem.Models
{
    public class Location
    {
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public String address { get; set; }
        [Required]
        [StringLength(30)]
        public string city { get; set; }
        //[Required]
        //[MaxLength(12)]
        //[MinLength(1)]
        //[RegularExpression("[0-9]", ErrorMessage = "Quantity must be numeric")]
        public int zipcode { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
    }
    
}