using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JoachimKarlssonMvc.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Name { get; set; }

        public string ImgUrl { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string ShortDescription { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Price { get; set; }
    }
}
