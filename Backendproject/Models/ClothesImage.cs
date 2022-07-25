﻿using Backendproject.Models.Base;
using Backendproject.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.Models
{
    public class ClothesImage:BaseEntity
    {
        
        public string Name { get; set; }
        [Required,MaxLength(30)]
        public string Alternative { get; set; }
        [Required]
        public bool IsMain { get; set; }
        public int ClothesId { get; set; }
        public Clothes Clothes { get; set; }
        [NotMapped]
        public IFormFile Photo{ get; set; }
    }
}
