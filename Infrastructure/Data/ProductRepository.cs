using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRespository
    {
        private readonly ECommerceContext _context;
        public ProductRepository(ECommerceContext context)
        {
         _context=context;   
        }

        public async Task<IReadOnlyList<ProductBrand>> GetBrand()
        {
            return await _context.ProductBrands.ToListAsync();
        }

        public async Task<IReadOnlyList<Product>> GetProdcut()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(int ProductId)
        {
           return await _context.Products.FindAsync(ProductId);
        }

        public async Task<IReadOnlyList<ProductType>> GetProductTypes()
        {
            return await _context.ProductTypes.ToListAsync();
        }
    }
}