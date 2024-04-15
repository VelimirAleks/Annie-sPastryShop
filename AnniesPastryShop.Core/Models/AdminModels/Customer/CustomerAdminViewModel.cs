namespace AnniesPastryShop.Core.Models.AdminModels.Customer
{
    public class CustomerAdminViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public int TotalOrders { get; set; }
        public int TotalReviews { get; set; }
        public IEnumerable <OrderAdminViewModel> Orders { get; set; } = new List<OrderAdminViewModel>();

        public IEnumerable<ReviewAdminViewModel> Reviews { get; set; } = new List<ReviewAdminViewModel>();
    }
}