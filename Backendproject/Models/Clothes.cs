using Backendproject.Models.Base;
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

        
       
        public IFormFile MainPhoto { get; set; }
       
        public List<IFormFile> DetailPhotos { get; set; }
        
        public List<int> ImageIds { get; set; }
       
        public List<int> SizeIds { get; set; }
        
        public int SizeId { get; set; }
     
        public int ColorId { get; set; }
        
        public int Quantity { get; set; }

       
        public List<string> ClothesColorSizeValues { get; set; }
    }
}
