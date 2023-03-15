using Equity.Unified.Technologies.Api.Models.Domain.Cart;
using Equity.Unified.Technologies.Api.Models.Domain.CartItem;
using Equity.Unified.Technologies.Api.Models.Domain.Category;
using Equity.Unified.Technologies.Api.Models.Domain.Product;
using Microsoft.EntityFrameworkCore;

namespace Equity.Unified.Technologies.Api.Data
{
    public class EquityContext : DbContext
    {
        public EquityContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Cart> Carts{ get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
