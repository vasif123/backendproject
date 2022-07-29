﻿using Backendproject.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.Models
{
    public class Order:BaseEntity
    {
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string CountryCode { get; set; }
        [Required]
        public string City{ get; set; }
        [Required]
        public string Address { get; set; }
        public bool? Status { get; set; }
        public List<CartItem> CartItems { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
