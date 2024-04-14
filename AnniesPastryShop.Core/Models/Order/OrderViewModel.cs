using System.ComponentModel.DataAnnotations;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Core.Models.Order
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int CartId { get; set; }

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(OrderAddressMaxLength,MinimumLength =OrderAddressMinLength,
            ErrorMessage =StringLengthErrorMessage)]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [RegularExpression(PhoneNumberRegex,ErrorMessage =PhoneNumberErrorMessage)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        public decimal GrandTotalPrice { get; set; }

        [Required(ErrorMessage = RequireErrorMessage)]
        public DateTime OrderDate { get; set; }=DateTime.UtcNow.Date;

        [StringLength(OrderCommentMaxLength,MinimumLength =OrderCommentMinLength,
            ErrorMessage =StringLengthErrorMessage)]
        public string? Comment { get; set; }

        [Required(ErrorMessage = RequireErrorMessage)]
        public PaymentMethodViewModel PaymentMethod { get; set; } = null!;

        [Required(ErrorMessage = RequireErrorMessage)]
        public IEnumerable<PaymentMethodViewModel> PaymentMethods { get; set; }=new List<PaymentMethodViewModel>();

        [Required(ErrorMessage = RequireErrorMessage)]
        public IEnumerable<OrderItemViewModel> OrderItems { get; set; } = new List<OrderItemViewModel>();

    }
}

