﻿using Backendproject.Models.Base;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.Models
{
    public class Clothes : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public string Description { get; set; }
        public string ExtraInfo { get; set; }
        public List<ClothesImage> ClothesImages { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public List<ClothesColor> ClothesColors { get; set; }

        //hele deqiq bilmirem bunlari
        [NotMapped]
        public int SizeId { get; set; }
        [NotMapped]
        public int ColorId { get; set; }
        public int? Id { get; internal set; }
    }
}
