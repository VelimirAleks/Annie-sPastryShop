namespace AnniesPastryShop.Core.Models.Cart
{
    public class CartViewModel
    {
        public int ProductId { get; set; }
        public int CartId { get; set; }
        public int Id { get; set; }
        public string UserId { get; set; }=null!;
        public decimal GrandTotal { get; set; }
        public IEnumerable<CartItemViewModel> CartItems { get; set; }=new List<CartItemViewModel>();
    }
}
