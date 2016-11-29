using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InventorySystem.Models;

namespace InventorySystem.ViewModel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipType { get; set; }
        public Location Location { get; set; }
        public Buyer Buyer { get; set; }
    }
}