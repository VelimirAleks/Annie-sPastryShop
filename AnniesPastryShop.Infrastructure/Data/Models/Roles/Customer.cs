using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Infrastructure.Data.Models.Roles
{
    [Comment("Customer role table")]
    public class Customer
    {
        [Key]
        [Comment("Customer identifier")]
        public int Id { get; set; }

        [Comment("Associated user")]
        [Required]
        public string UserId { get; set; } = null!;

        [Comment("Associated user")]
        [Required]
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Comment("Customer full name")]
        [Required]
        [MaxLength(CustomerNameMaxLength)]
        public string FullName { get; set; } = string.Empty;

        [Comment("Collection of orders")]
        public ICollection<Order> Orders { get; set; } = new List<Order>();

        [Comment("Collection of reviews")]
        public ICollection<Review> Reviews { get; set; }= new List<Review>();
    }
}