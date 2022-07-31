using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.ViewModels.Cart
{
    public class CartVM
    {
        public List<CartItemVM> CartItemVMs { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
