using System.ComponentModel.DataAnnotations;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Core.Models.Review
{
    public class ReviewViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage =RequireErrorMessage)]
        [Range(ReviewRatingMinValue,ReviewRatingMaxValue,ErrorMessage =RangeErrorMessage)]
        public int Rating { get; set; }

        [StringLength(ReviewCommentMaxLength,MinimumLength =ReviewCommentMinLength,
            ErrorMessage =StringLengthErrorMessage)]
        public string? Comment{ get; set; }

        [Required(ErrorMessage =RequireErrorMessage)]
        public DateTime CreatedAt { get; set; }=DateTime.UtcNow;
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;

        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
    }
}
 