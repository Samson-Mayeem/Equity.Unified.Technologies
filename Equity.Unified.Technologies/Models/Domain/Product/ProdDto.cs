namespace Equity.Unified.Technologies.Api.Models.Domain.Product
{
    public class ProdDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public decimal Qty { get; set; }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
