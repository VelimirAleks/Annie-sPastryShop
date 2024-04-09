using AnniesPastryShop.Core.Models.Cart;

namespace AnniesPastryShop.Core.Contracts
{
    public interface ICartService
    {
        Task <CartViewModel?> GetCartAsync(string userId);
        Task<bool> AddProductToCartAsync(int productId, int quantity, string userId);
        Task<bool> UpdateCartItemQuantityAsync(int cartItemId, int newQuantity);
        Task<bool> RemoveCartItemFromCartAsync(int cartItemId);
        Task<bool> ClearCartAsync(string userId);
    }
}
