﻿using Backendproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.ViewModels.Cart
{
    public class CartItemVM
    {
        public Clothes Clothes { get; set; }
        public byte Quantity { get; set; }
        public int ColorId { get; set; }
        public int SizeId { get; set; }
    }
}
