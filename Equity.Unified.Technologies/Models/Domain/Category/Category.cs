using System.ComponentModel.DataAnnotations;

namespace Equity.Unified.Technologies.Api.Models.Domain.Category
{
    public class Category
    {
        [Key]
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
