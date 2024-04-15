namespace AnniesPastryShop.Core.Models.AdminModels.Customer
{
    public class ReviewAdminViewModel
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }=string.Empty;
        public DateTime CreatedAt { get; set; } 
        public string ProductName { get; set; } = string.Empty;
    }
}
