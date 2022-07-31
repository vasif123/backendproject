using Backendproject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.ViewModels
{
    public class ProductVM
    {
        internal List<ClothesColorSize> ClothesColorSizes;

        public Clothes Clothes { get; set; }
        public List<Clothes> Clotheses { get; set; }
        public List<ClothesColorSize> ColorSizes { get; set; }

    }
}
