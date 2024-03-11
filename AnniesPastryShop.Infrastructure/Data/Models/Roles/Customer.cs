using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AnniesPastryShop.Infrastructure.Data.Models.Roles
{
    [Comment("Customer role table")]
    public class Customer
    {
        [Key]
        [Comment("Administrator identifier")]
        public int Id { get; set; }

        [Comment("Associated user")]
        [Required]
        public string UserId { get; set; } = null!;

        [Comment("Associated user")]
        [Required]
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
    }
}