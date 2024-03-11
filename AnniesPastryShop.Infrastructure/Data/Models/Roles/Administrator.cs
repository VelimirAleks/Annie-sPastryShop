using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnniesPastryShop.Infrastructure.Data.Models.Roles
{
    [Comment("Administrator role table")]
    public class Administrator
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
