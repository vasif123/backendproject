using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.ViewModels.Cart
{
    public class CartCookieVM
    {
        public List<CartCookieItemVM> CartCookieItemVMs { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
