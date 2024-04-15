namespace AnniesPastryShop.Core.Models.AdminModels.Customer
{
    public class OrderAdminViewModel
    {
        public int Id { get; set; }

        public string Address { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Comment { get; set; } = string.Empty;

        public DateTime OrderDate { get; set; }

        public decimal GrandTotalPrice { get; set; }

        public string PaymentType { get; set; } = string.Empty;
    }
}
