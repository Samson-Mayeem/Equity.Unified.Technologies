namespace Equity.Unified.Technologies.Api.Models.Domain.CartItem
{
    public class CartItemAddToDto
    {
        public long CartId { get; set; }
        public long ProductId { get; set; }
        public int Qty { get; set; }
    }
}
