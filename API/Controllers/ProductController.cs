using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using API.Entities;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly StoreContext _context;

        public ProductController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            var products = _context.Products.ToList();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            return _context.Products.Find(id);
        }
    }
}