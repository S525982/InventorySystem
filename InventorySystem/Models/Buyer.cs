using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventorySystem.Models
{
    public class Buyer
    {
        public int BuyerId { get; set; }
        [Required]
        [StringLength(255)]
        [Display (Name="First Name")]
        public String FName { get; set; }
        
        [StringLength(255)]
        [Display(Name = "Middle Name")]

        public String MName { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Last Name")]
        public String LName { get; set; }

        [Required]
        public bool Verified { get; set; }
        [Display(Name="MembershipType Type")]
        public MembershipType MembershipType { get; set; }

        public byte  MembershipTypeId { get; set; }

        public Location Location { get; set; }

        public int LocationId { get; set; }
    }
}