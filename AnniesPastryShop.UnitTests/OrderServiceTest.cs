using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Order;
using AnniesPastryShop.Core.Services;
using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AnniesPastryShop.UnitTests
{
    [TestFixture]
    public class OrderServiceTest
    {
        private ApplicationDbContext context;
        private IOrderServices orderService;


        [SetUp]
        public async Task Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "AnniesPastryShopInMemoryDb" + Guid.NewGuid().ToString())
                .Options;

            context = new ApplicationDbContext(options);

            var paymentMethod1 = new PaymentMethod { Name = "Credit Card" };
            var paymentMethod2 = new PaymentMethod { Name = "PayPal" };

            context.PaymentsMethods.AddRange(paymentMethod1, paymentMethod2);
            await context.SaveChangesAsync();

            orderService = new OrderServices(context);
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.Database.EnsureDeletedAsync();
            await context.DisposeAsync();
        }

        [Test]
        public async Task GetAllPaymentMethodsAsync_ShouldReturnAllPaymentMethods()
        {
            // Act
            var paymentMethods = await orderService.GetAllPaymentMethodsAsync();

            // Assert
            Assert.IsNotNull(paymentMethods);
            Assert.AreEqual(2, paymentMethods.Count());
        }

        [Test]
        public async Task GetPaymentMethodByIdAsync_ShouldReturnPaymentMethod()
        {
            // Arrange
            int existingPaymentMethodId = 1;

            // Act
            var paymentMethod = await orderService.GetPaymentMethodByIdAsync(existingPaymentMethodId);

            // Assert
            Assert.IsNotNull(paymentMethod);
            Assert.AreEqual(existingPaymentMethodId, paymentMethod.Id);
        }

        [Test]
        public async Task GetPaymentMethodByIdAsync_ShouldReturnNullForNonExistentPaymentMethodId()
        {
            // Arrange
            int nonExistentPaymentMethodId = 100;

            // Act
            var paymentMethod = await orderService.GetPaymentMethodByIdAsync(nonExistentPaymentMethodId);

            // Assert
            Assert.IsNull(paymentMethod);
        }

        [Test]
        public async Task PlaceOrderAsync_ShouldPlaceOrder()
        {
            // Arrange
            var model = new OrderViewModel
            {
                Address = "123 Main St",
                PhoneNumber = "1234567890",
                OrderDate = DateTime.Now,
                Comment = "Test order comment",
                PaymentMethod = new PaymentMethodViewModel { Id = 1, Name = "Credit Card" }
            };
            int cartId = 1;
            decimal grandTotalPrice = 50.0m;
            int customerId = 1;

            // Act
            var orderId = await orderService.PlaceOrderAsync(model, cartId, grandTotalPrice, customerId);

            // Assert
            var order = await context.Orders.FirstOrDefaultAsync(o => o.Id == orderId);
            Assert.IsNotNull(order);
            Assert.AreEqual(model.Address, order.Address);
            Assert.AreEqual(model.PhoneNumber, order.PhoneNumber);
            Assert.AreEqual(model.OrderDate, order.OrderDate);
            Assert.AreEqual(model.Comment, order.Comment);
            Assert.AreEqual(model.PaymentMethod.Id, order.PaymentMethodId);
            Assert.AreEqual(cartId, order.CartId);
            Assert.AreEqual(customerId, order.CustomerId);
        }

        [Test]
        public async Task GetAllPaymentMethodsAsync_ShouldReturnEmptyListForNoPaymentMethods()
        {
            // Arrange
            await context.Database.EnsureDeletedAsync();

            // Act
            var paymentMethods = await orderService.GetAllPaymentMethodsAsync();

            // Assert
            Assert.IsEmpty(paymentMethods);
        }
    }
}
