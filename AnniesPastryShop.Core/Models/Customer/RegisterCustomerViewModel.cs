using System.ComponentModel.DataAnnotations;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Core.Models.Customer
{
    public class RegisterCustomerViewModel
    {
        [Required(ErrorMessage =RequireErrorMessage)]
        [StringLength(CustomerNameMaxLength,MinimumLength =CustomerNameMinLength,
                       ErrorMessage =StringLengthErrorMessage)]
        public string FullName { get; set; }=string.Empty;

    }
}
