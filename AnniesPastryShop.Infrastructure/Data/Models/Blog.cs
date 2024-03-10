using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Infrastructure.Data.Models
{
    [Comment("Blog table")]
    public class Blog
    {
        public Blog()
        {
            CreatedAt = DateTime.UtcNow;
        }

        [Key]
        [Comment("Blog identifier")]
        public int Id { get; set; }

        [Comment("Blog title")]
        [Required]
        [MaxLength(BlogTitleMaxLength)]
        public string Title { get; set; } = string.Empty;

        [Comment("Blog content")]
        [Required]
        [MaxLength(BlogTitleMaxLength)]
        public string Content { get; set; } = string.Empty;

        [Comment("Blog image URL")]
        [Required]
        [Url]
        public string ImageUrl { get; set; } = string.Empty;

        [Comment("Date and time when the blog was created")]
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
