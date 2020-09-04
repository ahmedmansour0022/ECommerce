using System.Threading.Tasks;
using Core.Models;
using System.Collections.Generic;
namespace Core.Interfaces
{
    public interface IProductRespository
    {
        Task<Product> GetProductById(int ProductId);
        Task<IReadOnlyList<Product>>GetProdcut();
        Task<IReadOnlyList<ProductBrand>> GetBrand();
        Task<IReadOnlyList<ProductType>> GetProductTypes();
    }
}