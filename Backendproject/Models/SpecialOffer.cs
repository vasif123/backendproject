using Backendproject.Models.Base;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.Models
{
    public class SpecialOffer:BaseEntity
    {
        public string Image { get; set; }
        [Required,MaxLength(40)]
        public string Title { get; set; }
        [Required, MaxLength(50)]
        public string Discount { get; set; }
        public string ButtonUrl { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
