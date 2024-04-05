using System.ComponentModel.DataAnnotations;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Core.Models.Blog
{
    public class BlogViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage =RequireErrorMessage)]
        [StringLength(BlogTitleMaxLength,MinimumLength =BlogTitleMinLength,
            ErrorMessage =StringLengthErrorMessage)]
        public string Title { get; set; }=string.Empty;

        [Required(ErrorMessage =RequireErrorMessage)]
        [StringLength(BlogContentMaxLength,MinimumLength =BlogContentMinLength,
                       ErrorMessage =StringLengthErrorMessage)]
        public string Content { get; set; } = string.Empty;

        [Required(ErrorMessage =RequireErrorMessage)]
        [Url(ErrorMessage =UrlFormatErrorMessage)]
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage =RequireErrorMessage)]
        public DateTime CreatedAt { get; set; }=DateTime.UtcNow.Date;
    }
}
