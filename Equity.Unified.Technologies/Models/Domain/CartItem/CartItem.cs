using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Equity.Unified.Technologies.Api.Models.Domain.CartItem
{
    public class CartItem
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("CartId")]
        public int CartId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public int Qty { get; set; }
    }
}
