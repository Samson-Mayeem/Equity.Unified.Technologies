using Equity.Unified.Technologies.Api.Models.Domain.Category;
using Equity.Unified.Technologies.Api.Models.Domain.Product;

namespace Equity.Unified.Technologies.Api.Repos.Contracts
{
    public interface IProductRepo
    {
        Task<IEnumerable<Product>> GetProds();
        Task<Product>AddProd(Product product);
        Task<Product> GetProd(int id);
        Task<Product> DeletProd(int id);
    }
}
