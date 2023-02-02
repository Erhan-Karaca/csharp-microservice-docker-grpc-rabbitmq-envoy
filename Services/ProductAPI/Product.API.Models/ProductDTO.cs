using System;

namespace Product.API.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Model { get; set; }
        public Double Price { get; set; }
    }
}
