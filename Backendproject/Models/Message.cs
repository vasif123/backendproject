using Backendproject.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backendproject.Models
{
    public class Message:BaseEntity
    {
        [Required,MaxLength(30)]
        public string Name { get; set; }
        [Required,MaxLength(50),DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,MaxLength(25)]
        public string Subject { get; set; }
        [Required,MaxLength(1000)]
        public string MessageText { get; set; }
    }
}
