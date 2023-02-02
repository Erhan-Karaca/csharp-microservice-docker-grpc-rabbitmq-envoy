using Product.API.Infrastructure;
using Product.API.Models;
using System;

namespace Product.API.Services
{
    public class ProductService : IProductService
    {
        public ProductDTO GetProductById(int Id)
        {
            return new ProductDTO()
            {
                Id = Id,
                Name = "Product 1",
                Model = "Model 1",
                Price = 23.50
            };
        }
    }
}
