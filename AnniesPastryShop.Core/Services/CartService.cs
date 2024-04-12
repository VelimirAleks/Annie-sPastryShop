using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Cart;
using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AnniesPastryShop.Core.Services
{
    public class CartService : ICartService
    {
        private readonly ApplicationDbContext context;

        public CartService(ApplicationDbContext _context)
        {
            context = _context;
        }
        public async Task<bool> AddProductToCartAsync(int productId, int quantity, string userId)
        {
            var cart = await context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.Customer.UserId == userId);
            if (cart == null)
            {
                throw new Exception("Cart not found for the user.");
            }
            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    ProductId = productId,
                    Quantity = quantity,
                    CartId = cart.Id
                };
                await context.CartsItems.AddAsync(cartItem);
            }
            else
            {
                cartItem.Quantity += quantity;
            }
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ClearCartAsync(string userId)
        {
            var cart = await context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.Customer.UserId == userId);
            if (cart != null)
            {
                context.CartsItems.RemoveRange(cart.CartItems);
                await context.SaveChangesAsync();
            }
            return true;
        }

        public async Task<CartViewModel?> GetCartAsync(string userId)
        {
            var cart = await context.Carts
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(c => c.Customer.UserId == userId);
            if (cart == null)
            {
                return null;
            }
            var cartViewModel = new CartViewModel
            {
                Id = cart.Id,
                CartItems = cart.CartItems
                .Select(ci => new CartItemViewModel
                {
                    Id = ci.Id,
                    ProductId = ci.Product.Id,
                    ProductName = ci.Product.Name,
                    ProductImageUrl = ci.Product.ImageUrl,
                    Quantity = ci.Quantity,
                    ProductPrice = ci.Product.Price,
                    TotalPrice = ci.Product.Price * ci.Quantity
                })
                .ToList()
            };
            return cartViewModel;
        }

        public async Task<bool> RemoveCartItemFromCartAsync(int productId, int cartId)
        {
            var cartItem = await context.CartsItems
                .FirstOrDefaultAsync(ci => ci.ProductId == productId && ci.CartId == cartId);

            if (cartItem!=null)
            {
                context.CartsItems.Remove(cartItem);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> UpdateCartItemQuantityAsync(int productId, int cartId, int newQuantity)
        {
            var cartItem = await context.CartsItems
                .FirstOrDefaultAsync(ci => ci.ProductId == productId && ci.CartId == cartId);

            if (cartItem!=null)
            {
                cartItem.Quantity = newQuantity;
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
