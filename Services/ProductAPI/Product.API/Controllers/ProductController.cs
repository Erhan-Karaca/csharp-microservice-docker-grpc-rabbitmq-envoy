using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.API.Infrastructure;
using Product.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService ProductService)
        {
            productService = ProductService;
        }

        // GET api/<ProductController>/5
        [HttpGet("{Id}")]
        public ProductDTO Get(int Id)
        {
            return productService.GetProductById(Id);
        }
    }
}
