﻿using Backendproject.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.Models
{
    public class ClothesColor:BaseEntity
    {
        public int ClothesId { get; set; }
        public Clothes Clothes { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public List<ClothesColorSize> ClothesColorSizes { get; set; }

    }
}
