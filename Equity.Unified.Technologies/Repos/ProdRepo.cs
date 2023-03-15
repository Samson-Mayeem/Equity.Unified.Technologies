using Equity.Unified.Technologies.Api.Data;
using Equity.Unified.Technologies.Api.Models.Domain.Category;
using Equity.Unified.Technologies.Api.Models.Domain.Product;
using Equity.Unified.Technologies.Api.Repos.Contracts;
using Microsoft.EntityFrameworkCore;
using static Equity.Unified.Technologies.Api.Repos.ProdRepo;

namespace Equity.Unified.Technologies.Api.Repos
{
    public class ProdRepo
    {
        public class ProductRepository : IProductRepo
        {
            private readonly EquityContext dataContext;

            public ProductRepository(EquityContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<Product>> GetProds()
            {
                var products = await this.dataContext.Products.ToListAsync();
                return products;
            }
            public async Task<Product> productAsync(Product product)
            {
                var categories = await this.dataContext.AddAsync(product);//this.dataContext.Category.ToListAsync();
                return categories;
            }

            public Task<Category> GetCategory(int id)
            {
                return GetCategory(id);
            }

            public Task<Product> GetProd(int id)
            {
                throw new NotImplementedException();
            }
        }
    }
}
