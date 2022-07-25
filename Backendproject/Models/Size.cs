using Backendproject.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.Models
{
    public class Size:BaseEntity
    {
        public string Name { get; set; }
        public List<ColorSize> ColorSizes { get; set; }


    }
}
