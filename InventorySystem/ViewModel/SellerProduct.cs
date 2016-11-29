using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventorySystem.ViewModel
{
    public class SellerProduct
    {
        public Product Product { get; set; }
        public Seller Seller{ get; set; }
    }
}