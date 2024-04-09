namespace AnniesPastryShop.Core.Models.Cart
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }=null!;
        public IEnumerable<CartItemViewModel> CartItems { get; set; }=new List<CartItemViewModel>();
    }
}
