﻿using Backendproject.Models.Base;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.Models
{
    public class Category : BaseEntity
    {
        [Required, StringLength(maximumLength: 20)]
        public string Name { get; set; }
        public string Image { get; set; }
        public List<Clothes> Clothes { get; set; }
        [NotMapped]
        public IFormFile Photo{ get; set; }
        public int? Id { get; internal set; }
    }
}
