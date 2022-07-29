﻿
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.Models
{
    public class AppUser:IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<CartItem> CartItems { get; set; }
        public List<Order> Orders { get; set; }
        public List<WishlistItem> WishlistItems { get; set; }

    }
}
