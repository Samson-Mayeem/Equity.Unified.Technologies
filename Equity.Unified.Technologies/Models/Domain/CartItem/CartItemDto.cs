namespace Equity.Unified.Technologies.Api.Models.Domain.CartItem
{
    public class CartItemDto
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string productName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImageURL { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int Qty { get; set; }
    }
}
