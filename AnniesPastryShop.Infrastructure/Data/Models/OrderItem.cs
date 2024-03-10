using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Infrastructure.Data.Models
{
    [Comment("Order items table")]
    public class OrderItem
    {
        [Key]
        [Comment("Order item identifier")]
        public int Id { get; set; }

        [Comment("Item quantity")]
        [Required]
        [Range(OrderItemQuantityMinValue, OrderItemQuantityMaxValue)]
        public int Quantity { get; set; }

        [Comment("Item price")]
        [Required]
        [Range(OrderItemTotalPriceMinValue, OrderItemTotalPriceMaxValue)]
        public decimal TotalPrice { get; set; }

        [Comment("Associated product")]
        [Required]
        public int ProductId { get; set; }

        [Comment("Associated product")]
        [Required]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;


        [Comment("Associated order")]
        [Required]
        public int OrderId { get; set; }

        [Comment("Associated order")]
        [Required]
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = null!;
    }
}