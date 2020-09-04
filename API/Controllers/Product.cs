using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;
using Core.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Product : ControllerBase
    {
        private readonly IProductRespository _context;
        public Product(IProductRespository context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> getProdcuts() {
            return Ok(await _context.GetProdcut());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> getproduct(int id) {
            return Ok(await _context.GetProductById(id));
        }
        [HttpGet("Brand")]
        public async Task<ActionResult<List<ProductBrand>>>GetBrands(){
            return Ok(await _context.GetBrand());
        }
        [HttpGet("Types")]
        public async Task<ActionResult<List<ProductType>>> GetTypes()
        {
            return Ok(await _context.GetProductTypes());
        }
    }
}