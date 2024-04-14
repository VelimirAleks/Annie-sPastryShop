namespace AnniesPastryShop.Core.Contracts
{
    public interface ICustomerService
    {
        Task<bool> SaveAdditionalDetailsAsync(string userId, string fullName);
        Task<bool> IsUserCustomerAsync(string userId);
        Task <bool> CreateCartAsync(string userId);
        Task <int> GetCartIdForCustomerAsync(string userId);
        Task <int> GetCustomerIdByUserId (string userId);
    }
}
