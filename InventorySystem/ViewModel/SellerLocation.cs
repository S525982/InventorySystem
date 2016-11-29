using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InventorySystem.Models;

namespace InventorySystem.ViewModel
{
    public class SellerLocation
    {
        public IEnumerable<Location> Location { get; set; }
        public Seller Seller { get; set; }
    }
}