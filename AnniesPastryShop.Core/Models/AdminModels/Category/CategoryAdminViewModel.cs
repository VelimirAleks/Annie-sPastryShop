using System.ComponentModel.DataAnnotations;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Core.Models.AdminModels.Category
{
    public class CategoryAdminViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage =RequireErrorMessage)]
        [StringLength(CategoryNameMaxLength,MinimumLength =CategoryNameMinLength,
            ErrorMessage =StringLengthErrorMessage)]
        public string Name { get; set; }=string.Empty;
    }
}
