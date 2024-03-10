using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Infrastructure.Data.Models
{
    [Comment("Cart items table ")]
    public class CartItem
    {
        [Key]
        [Comment("Cart item identifier")]
        public int Id { get; set; }

        [Comment("Item quantity")]
        [Required]
        [Range(CartItemQuantityMinValue,CartItemQuantityMaxValue)]
        public int Quantity { get; set; }

        [Comment("Item price")]
        [Required]
        [Range(CartItemTotalPriceMinValue,CartItemTotalPriceMaxValue)]
        public decimal TotalPrice { get; set; }

        [Comment("Associated product")]
        [Required]
        public int ProductId { get; set; }

        [Comment("Associated product")]
        [Required]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [Comment("Associated cart")]
        [Required]
        public int CartId { get; set; }

        [Comment("Associated cart")]
        [Required]
        [ForeignKey(nameof(CartId))]
        public Cart Cart { get; set; } = null!;
    }
}