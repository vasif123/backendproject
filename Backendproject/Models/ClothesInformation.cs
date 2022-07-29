using Backendproject.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.Models
{
    public class ClothesInformation:BaseEntity
    {
        [Required]
        public string AdditionalInfo { get; set; }
        [Required,MaxLength(50)]
        public string Definition { get; set; }
        public List<Clothes> Clothes { get; set; }
    }
}
