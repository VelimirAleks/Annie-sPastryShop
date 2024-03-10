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
        public string Url { get; set; } = string.Empty;

        [Comment("Associated Product")]
        [Required]
        public int ProductId { get; set; }

        [Comment("Associated Product")]
        [Required]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}