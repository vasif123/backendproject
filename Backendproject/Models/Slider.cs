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
    public class Slider:BaseEntity
    {
        public string Image { get; set; }
        [Required(ErrorMessage ="Please enter the title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the article")]
        public string Article { get; set; }
        public string ButtonUrl { get; set; }
        [Required(ErrorMessage = "Please enter the order")]
        public byte Order { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
