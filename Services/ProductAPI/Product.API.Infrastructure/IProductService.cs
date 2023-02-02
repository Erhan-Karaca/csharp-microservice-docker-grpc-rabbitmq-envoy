using Product.API.Models;
using System;

namespace Product.API.Infrastructure
{
    public interface IProductService
    {
        public ProductDTO GetProductById(int Id);
    }
}
