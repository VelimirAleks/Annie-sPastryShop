using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Infrastructure.Data.Models
{
    [Comment("Products table")]
    public class Product
    {
        [Key]
        [Comment("Product identifier")]
        public int Id { get; set; }

        [Comment("Product name")]
        [Required]
        [MaxLength(ProductNameMaxLength)]
        public string Name { get; set; }=string.Empty;

        [Comment("Product price")]
        [Required]
        [Range(PriceMinValue,PriceMaxValue)]
        public decimal Price { get; set; }

        [Comment("Product description")]
        [Required]
        [MaxLength(ProductDescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Comment("Product image")]
        [Required]
        [Url]
        public string ImageUrl { get; set; } = string.Empty;

        [Comment("Product category")]
        [Required]
        public int CategoryId { get; set; }

        [Comment("Product category")]
        [Required]
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Comment("Collection of pictures")]
        public ICollection<Picture> Pictures { get; set; } = new List<Picture>();

        [Comment("Collection of reviews")]
        public ICollection<Review> Reviews { get; set; } = new List<Review>();

        [Comment("Collection of cart items")]
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

        [Comment("Collection of order details")]
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
