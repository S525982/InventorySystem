using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventorySystem.Models
{
    public class Seller
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "First Name")]
        public string FName { get; set; }

        [StringLength(255)]
        [Display(Name = "Middle Name")]
        public string MName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        public Location Location { get; set; }

        public int LocationId { get; set; }
    }
}