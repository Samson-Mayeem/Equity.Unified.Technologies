using Equity.Unified.Technologies.Api.Models.Domain.Category;
using Equity.Unified.Technologies.Api.Models.Domain.Product;

namespace Equity.Unified.Technologies.Api.DtoConvertions
{
    public static class DtoConvertions
    {
        public static IEnumerable<ProdDto>
            ConvertProductToDto(this IEnumerable<Product> Products,
                              IEnumerable<Category> Categories)
        {
            return (from Product in Products
                         join Category in Categories
                         on Product.ProdId equals Category.CategoryId
                         select new ProdDto
                         {
                            Id= Product.ProdId,
                            Name = Product.ProductName,
                            Description = Product.Description,
                            ImageURL = Product.ImageUrl,
                            Price = Product.Price,
                            Qty = Product.Qty,
                            CategoryId = Category.CategoryId,
                            CategoryName = Category.CategoryName
                    }).ToList();
        }
    }
}
