using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Infrastructure.Data.Models
{
    [Comment("Categories table")]
    public class Category
    {
        [Key]
        [Comment("Category identifier")]
        public int Id { get; set; }

        [Comment("Category name")]
        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Comment("Collection of products")]
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}