using System.ComponentModel.DataAnnotations;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace AnniesPastryShop.Core.Models.Cart
{
    public class CartItemViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } =string.Empty;
        public string ProductImageUrl { get; set; }=string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [Range(OrderItemQuantityMinValue,OrderItemQuantityMaxValue,
            ErrorMessage = QuantityErrorMessage)]
        public int Quantity { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int CartId { get; set; } 
    }
}
