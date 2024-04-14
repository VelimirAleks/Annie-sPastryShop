namespace AnniesPastryShop.Core.Models.Order
{
    public class OrderItemViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
