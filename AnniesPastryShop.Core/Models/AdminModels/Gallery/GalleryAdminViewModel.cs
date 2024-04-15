using System.ComponentModel.DataAnnotations;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Core.Models.AdminModels.Gallery
{
    public class GalleryAdminViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage =RequireErrorMessage)]
        [Url(ErrorMessage =UrlFormatErrorMessage)]
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage =RequireErrorMessage)]
        public int ProductId { get; set; }
    }
}
