using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Product : ControllerBase
    {
        private readonly ECommerceContext _context;
        public Product(ECommerceContext context)
        {
            _context=context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> getProdcuts(){
            return Ok(await _context.Products.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> getproduct(int id){
          return Ok(await _context.Products.FindAsync(id));
        }
    }
}