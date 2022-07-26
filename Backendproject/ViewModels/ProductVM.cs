using Backendproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.ViewModels
{
    public class ProductVM
    {
        public Clothes Clothes { get; set; }
        public List<Clothes> Clotheses { get; set; }

    }
}
