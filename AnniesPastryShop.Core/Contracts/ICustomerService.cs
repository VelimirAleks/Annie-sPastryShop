namespace AnniesPastryShop.Core.Contracts
{
    public interface ICustomerService
    {
        Task<bool> SaveAdditionalDetailsAsync(string userId, string fullName);
    }
}
