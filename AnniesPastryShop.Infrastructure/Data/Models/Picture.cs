using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnniesPastryShop.Infrastructure.Data.Models
{
    [Comment("Pictures table")]
    public class Picture
    {
        [Key]
        [Comment("Pictures identifier")]
        public int Id { get; set; }

        [Comment("Pictures url")]
        [Required]
        [Url]
        public string ImageUrl { get; set; } = string.Empty;

        [Comment("Associated product")]
        [Required]
        public int ProductId { get; set; }

        [Comment("Associated product")]
        [Required]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}