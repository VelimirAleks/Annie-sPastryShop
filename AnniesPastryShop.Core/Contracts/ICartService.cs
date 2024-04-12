using AnniesPastryShop.Core.Models.Cart;

namespace AnniesPastryShop.Core.Contracts
{
    public interface ICartService
    {
        Task <CartViewModel?> GetCartAsync(string userId);
        Task<bool> AddProductToCartAsync(int productId, int quantity, string userId);
        Task<bool> UpdateCartItemQuantityAsync(int productId, int cartId, int newQuantity);
        Task<bool> RemoveCartItemFromCartAsync(int productId, int cartId);
        Task<bool> ClearCartAsync(string userId);
    }
}
