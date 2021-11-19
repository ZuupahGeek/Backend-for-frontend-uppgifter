using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoachimKarlssonMvc.Models
{
    public class CreateProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public string ShortDescription { get; set; }
        public string Price { get; set; }
    }
}

