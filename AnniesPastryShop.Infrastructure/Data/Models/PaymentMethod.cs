using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AnniesPastryShop.Infrastructure.Data.Models
{
    [Comment("Payment methods table")]
    public class PaymentMethod
    {
        [Key]
        [Comment("Payment method identifier")]
        public int Id { get; set; }

        [Comment("Payment method name")]
        [Required]
        public string Name { get; set; } = string.Empty;

        [Comment("Collection of orders")]
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}