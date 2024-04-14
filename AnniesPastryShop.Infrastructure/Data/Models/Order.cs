using AnniesPastryShop.Infrastructure.Data.Models.Roles;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;
namespace AnniesPastryShop.Infrastructure.Data.Models
{
    [Comment("Order table")]
    public class Order
    {
        public Order()
        {
            OrderDate = DateTime.UtcNow;
        }

        [Key]
        [Comment("Order identifier")]
        public int Id { get; set; }

        [Comment("Shipping address")]
        [Required]
        [MaxLength(OrderAddressMaxLength)]
        public string Address { get; set; } = string.Empty;

        [Comment("Phone number for contact")]
        [Required]
        [RegularExpression(PhoneNumberRegex)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Comment("Order total price")]
        [Required]
        public decimal TotalPrice { get; set; }

        [Comment("Order date")]
        [Required]
        public DateTime OrderDate { get; set; }

        [Comment("Order comment if necessary")]
        [MaxLength(OrderCommentMaxLength)]
        public string? Comment { get; set; }

        [Comment("Associated payment method")]
        [Required]
        public int PaymentMethodId { get; set; }

        [Comment("Associated payment method")]
        [Required]
        [ForeignKey(nameof(PaymentMethodId))]
        public PaymentMethod PaymentMethod { get; set; } = null!;

        [Comment("Associated cart")]
        [Required]
        public int CartId { get; set; }

        [Comment("Associated cart")]
        [Required]
        [ForeignKey(nameof(CartId))]
        public Cart Cart { get; set; } = null!;

    }
}