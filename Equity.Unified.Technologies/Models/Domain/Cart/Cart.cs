using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Equity.Unified.Technologies.Api.Models.Domain.Cart
{
    public class Cart
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("UserId")]
        public long UserId { get; set; }
    }
}
