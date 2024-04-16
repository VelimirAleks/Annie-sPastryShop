using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Services;
using AnniesPastryShop.Infrastructure.Data.Models;
using AnniesPastryShop.Infrastructure.Data.Models.Roles;
using Microsoft.EntityFrameworkCore;

namespace AnniesPastryShop.UnitTests
{
    [TestFixture]
    public class CartServiceTest
    {
        private ApplicationDbContext context;
        private ICartService cartService;

        private Cart cart;
        private Product product;

        [SetUp]
        public async Task Setup()
        {
            cart = new Cart
            {
                Id = 1,
                CustomerId = 1,
                Customer = new Customer { UserId = "user1" }
            };

            product = new Product
            {
                Id = 1,
                Name = "Chocolate Cake",
                Price = 20.0m,
                ImageUrl = "https://example.com/chocolate-cake.jpg"
            };

            var cartItem = new CartItem
            {
                Id = 1,
                CartId = cart.Id,
                Cart = cart,
                ProductId = product.Id,
                Product = product,
                Quantity = 2
            };

            cart.CartItems.Add(cartItem);

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "AnniesPastryShopInMemoryDb" + Guid.NewGuid().ToString())
                .Options;

            context = new ApplicationDbContext(options);

            context.Carts.Add(cart);
            context.Products.Add(product);
            await context.SaveChangesAsync();

            cartService = new CartService(context);
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.Database.EnsureDeletedAsync();
            await context.DisposeAsync();
        }

        [Test]
        public async Task AddProductToCartAsync_ShouldAddProductToCart()
        {
            // Arrange
            int productId = 2; // New product ID
            int quantity = 1;
            string userId = "user1";

            // Act
            await cartService.AddProductToCartAsync(productId, quantity, userId);

            // Assert
            var updatedCart = await context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.Customer.UserId == userId);

            Assert.IsNotNull(updatedCart);
            Assert.AreEqual(2, updatedCart.CartItems.Count);
            Assert.IsTrue(updatedCart.CartItems.Any(ci => ci.ProductId == productId && ci.Quantity == quantity));
        }

        [Test]
        public async Task ClearCartAsync_ShouldClearCart()
        {
            // Arrange
            string userId = "user1";

            // Act
            await cartService.ClearCartAsync(userId);

            // Assert
            var clearedCart = await context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.Customer.UserId == userId);

            Assert.IsNotNull(clearedCart);
            Assert.IsEmpty(clearedCart.CartItems);
        }

        [Test]
        public async Task GetCartAsync_ShouldReturnCart()
        {
            // Arrange
            string userId = "user1";

            // Act
            var cartViewModel = await cartService.GetCartAsync(userId);

            // Assert
            Assert.IsNotNull(cartViewModel);
            Assert.AreEqual(cart.Id, cartViewModel.Id);
            Assert.AreEqual(cart.CartItems.Count, cartViewModel.CartItems.Count());
            Assert.IsTrue(cart.CartItems.All(ci => cartViewModel.CartItems.Any(civm => civm.Id == ci.Id)));
        }

        [Test]
        public async Task RemoveCartItemFromCartAsync_ShouldRemoveCartItem()
        {
            // Arrange
            int productId = product.Id;
            int cartItemId = 1; // Cart item ID
            string userId = "user1";

            // Act
            await cartService.RemoveCartItemFromCartAsync(productId, cartItemId);

            // Assert
            var updatedCart = await context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.Customer.UserId == userId);

            Assert.IsNotNull(updatedCart);
            Assert.AreEqual(0, updatedCart.CartItems.Count);
        }

        [Test]
        public async Task UpdateCartItemQuantityAsync_ShouldUpdateCartItemQuantity()
        {
            // Arrange
            int productId = product.Id;
            int cartItemId = 1; 
            int newQuantity = 3;
            string userId = "user1";

            // Act
            await cartService.UpdateCartItemQuantityAsync(productId, cartItemId, newQuantity);

            // Assert
            var updatedCart = await context.Carts
                .Include(c => c.CartItems)
                .FirstOrDefaultAsync(c => c.Customer.UserId == userId);

            Assert.IsNotNull(updatedCart);
            var updatedCartItem = updatedCart.CartItems.FirstOrDefault(ci => ci.Id == cartItemId);
            Assert.IsNotNull(updatedCartItem);
            Assert.AreEqual(newQuantity, updatedCartItem.Quantity);
        }

        [Test]
        public async Task GetCartAsync_ShouldReturnNullForNonExistentCart()
        {
            // Arrange
            string nonExistentUserId = "non_existent_user_id";

            // Act
            var cartViewModel = await cartService.GetCartAsync(nonExistentUserId);

            // Assert
            Assert.IsNull(cartViewModel);
        }

        [Test]
        public async Task RemoveCartItemFromCartAsync_ShouldReturnFalseForNonExistentCartItem()
        {
            // Arrange
            int nonExistentProductId = 100;
            int cartId = 1;

            // Act
            var result = await cartService.RemoveCartItemFromCartAsync(nonExistentProductId, cartId);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public async Task ClearCartAsync_ShouldRemoveAllCartItems()
        {
            // Arrange
            var customer = new Customer { UserId = "valid_user_id" };
            var cart = new Cart { Customer = customer };
            cart.CartItems.Add(new CartItem { ProductId = 1, Quantity = 2 });
            cart.CartItems.Add(new CartItem { ProductId = 2, Quantity = 1 });
            context.Carts.Add(cart);
            await context.SaveChangesAsync();

            string userId = "valid_user_id";

            // Act
            await cartService.ClearCartAsync(userId);

            // Assert
            var updatedCart = await context.Carts.Include(c => c.CartItems).FirstOrDefaultAsync(c => c.Customer.UserId == userId);
            Assert.IsNotNull(updatedCart);
            Assert.IsEmpty(updatedCart.CartItems);
        }

        [Test]
        public async Task UpdateCartItemQuantityAsync_ShouldReturnFalseForNonExistentCartItem()
        {
            // Arrange
            int nonExistentProductId = 100;
            int cartId = 1;
            int newQuantity = 5;

            // Act
            var result = await cartService.UpdateCartItemQuantityAsync(nonExistentProductId, cartId, newQuantity);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
