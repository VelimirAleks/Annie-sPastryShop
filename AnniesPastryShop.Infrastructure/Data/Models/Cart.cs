using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnniesPastryShop.Infrastructure.Data.Models
{
    [Comment("Carts table")]
    public class Cart
    {
        [Key]
        [Comment("Cart identifier")]
        public int Id { get; set; }

        [Comment("Associated customer")]
        [Required]
        public int CustomerId { get; set; }

        [Comment("Associated customer")]
        [Required]
        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; } = null!;

        [Comment("Collection of cart items")]
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}