using AnniesPastryShop.Core.Models.AdminModels.Category;
using System.ComponentModel.DataAnnotations;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Core.Models.AdminModels.Product
{
    public class ProductAdminViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(ProductNameMaxLength, MinimumLength = ProductNameMinLength,
                       ErrorMessage = StringLengthErrorMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [Range(PriceMinValue, PriceMaxValue, ErrorMessage = RangeErrorMessage)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(ProductDescriptionMaxLength, MinimumLength = ProductDescriptionMinLength,
                                  ErrorMessage = StringLengthErrorMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [Url(ErrorMessage = UrlFormatErrorMessage)]
        public string ImageUrl { get; set; } = string.Empty;
        [Required(ErrorMessage = RequireErrorMessage)]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = string.Empty;
        public List<CategoryAdminViewModel> Categories { get; set; }=new List<CategoryAdminViewModel>();

    }
}