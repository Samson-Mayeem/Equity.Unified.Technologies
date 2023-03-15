using System.ComponentModel.DataAnnotations;

namespace Equity.Unified.Technologies.Api.Models.Domain.Product
{
    public class Product
    {
        [Key]
        public long ProdId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
    }
}
