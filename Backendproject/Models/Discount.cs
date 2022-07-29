﻿using Backendproject.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.Models
{
    public class Discount:BaseEntity
    {
        [Required,MaxLength(30)]
        public string PercentKey { get; set; }
        [Required]
        public decimal PercentValue { get; set; }
        public List<Clothes> Clothes { get; set; }

    }
}
