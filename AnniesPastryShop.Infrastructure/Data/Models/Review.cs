using AnniesPastryShop.Infrastructure.Data.Models.Roles;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Infrastructure.Data.Models
{
    [Comment("Reviews table")]
    public class Review
    {
        public Review()
        {
            CreatedOn = DateTime.UtcNow;
        }

        [Key]
        [Comment("Review identifier")]
        public int Id { get; set; }

        [Comment("Review rating")]
        [Required]
        [Range(ReviewRatingMinValue,ReviewRatingMaxValue)]
        public int Rating { get; set; }

        [Comment("Review comment")]
        [MaxLength(ReviewCommentMaxLength)]
        public string? Comment { get; set; }

        [Comment("Date of creation of the review")]
        [Required]
        public DateTime CreatedOn { get; set; }

        [Comment("Associated product")]
        [Required]
        public int ProductId { get; set; }

        [Comment("Associated product")]
        [Required]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [Comment("Customer who made the review")]
        [Required]
        public int CustomerId { get; set; }

        [Comment("Customer who made the review")]
        [Required]
        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; } = null!;
    }
}