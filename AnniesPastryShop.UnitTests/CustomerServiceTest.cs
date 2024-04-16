using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Services;
using AnniesPastryShop.Infrastructure.Data.Models.Roles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnniesPastryShop.UnitTests
{
    [TestFixture]
    public class CustomerServiceTest
    {
        private ApplicationDbContext context;
        private ICustomerService customerService;

        [SetUp]
        public async Task Setup()
        {

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb" + Guid.NewGuid().ToString())
                .Options;

            context = new ApplicationDbContext(options);

            var customer1 = new Customer { UserId = "user1", FullName = "John Doe" };
            var customer2 = new Customer { UserId = "user2", FullName = "Jane Smith" };

            context.Customers.AddRange(customer1, customer2);
            await context.SaveChangesAsync();

            customerService = new CustomerService(context);
        }

        [TearDown]
        public async Task TearDown()
        {
            await context.Database.EnsureDeletedAsync();
            await context.DisposeAsync();
        }

        [Test]
        public async Task CreateCartAsync_ShouldCreateCartForExistingCustomer()
        {
            // Arrange
            string existingUserId = "user1";

            // Act
            var result = await customerService.CreateCartAsync(existingUserId);

            // Assert
            Assert.IsTrue(result);

            var customer = await context.Customers.FirstOrDefaultAsync(c => c.UserId == existingUserId);
            Assert.IsNotNull(customer);

            var cart = await context.Carts.FirstOrDefaultAsync(c => c.CustomerId == customer.Id);
            Assert.IsNotNull(cart);
        }

        [Test]
        public async Task CreateCartAsync_ShouldNotCreateCartForNonExistingCustomer()
        {
            // Arrange
            string nonExistingUserId = "nonExistingUserId";

            // Act
            var result = await customerService.CreateCartAsync(nonExistingUserId);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetAllCustomersAsync_ShouldReturnAllCustomers()
        {
            // Act
            var customers = await customerService.GetAllCustomersAsync();

            // Assert
            Assert.IsNotNull(customers);
            Assert.AreEqual(2, customers.Count());
        }

        [Test]
        public async Task GetCustomerByIdAsync_ShouldReturnCustomer()
        {
            // Arrange
            int existingCustomerId = 1;

            // Act
            var customer = await customerService.GetCustomerByIdAsync(existingCustomerId);

            // Assert
            Assert.IsNotNull(customer);
            Assert.AreEqual(existingCustomerId, customer.Id);
        }

        [Test]
        public async Task GetCustomerByIdAsync_ShouldReturnNullForNonExistentCustomerId()
        {
            // Arrange
            int nonExistentCustomerId = 100;

            // Act
            var customer = await customerService.GetCustomerByIdAsync(nonExistentCustomerId);

            // Assert
            Assert.IsNull(customer);
        }

        [Test]
        public async Task IsUserCustomerAsync_ShouldReturnTrueForExistingUser()
        {
            // Arrange
            string existingUserId = "user1";

            // Act
            var result = await customerService.IsUserCustomerAsync(existingUserId);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsUserCustomerAsync_ShouldReturnFalseForNonExistingUser()
        {
            // Arrange
            string nonExistingUserId = "nonExistingUserId";

            // Act
            var result = await customerService.IsUserCustomerAsync(nonExistingUserId);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public async Task SaveAdditionalDetailsAsync_ShouldUpdateCustomerFullName()
        {
            // Arrange
            string userId = "user1";
            string newFullName = "John Smith";

            // Act
            var result = await customerService.SaveAdditionalDetailsAsync(userId, newFullName);

            // Assert
            Assert.IsTrue(result);

            var customer = await context.Customers.FirstOrDefaultAsync(c => c.UserId == userId);
            Assert.IsNotNull(customer);
            Assert.AreEqual(newFullName, customer.FullName);
        }

        [Test]
        public async Task SaveAdditionalDetailsAsync_ShouldCreateNewCustomerIfNotExists()
        {
            // Arrange
            string newUserId = "newUser";
            string fullName = "New User";

            // Act
            var result = await customerService.SaveAdditionalDetailsAsync(newUserId, fullName);

            // Assert
            Assert.IsTrue(result);

            var customer = await context.Customers.FirstOrDefaultAsync(c => c.UserId == newUserId);
            Assert.IsNotNull(customer);
            Assert.AreEqual(fullName, customer.FullName);
        }

        [Test]
        public async Task GetCustomerIdByUserId_ShouldReturnCustomerIdForExistingUserId()
        {
            // Arrange
            string existingUserId = "user1";

            // Act
            var customerId = await customerService.GetCustomerIdByUserId(existingUserId);

            // Assert
            Assert.AreNotEqual(0, customerId);
        }

        [Test]
        public async Task GetCustomerIdByUserId_ShouldReturnZeroForNonExistingUserId()
        {
            // Arrange
            string nonExistingUserId = "nonExistingUserId";

            // Act
            var customerId = await customerService.GetCustomerIdByUserId(nonExistingUserId);

            // Assert
            Assert.AreEqual(0, customerId);
        }

        [Test]
        public async Task GetAllCustomersAsync_ShouldReturnEmptyListWhenNoCustomersExist()
        {
            // Arrange
            await context.Database.EnsureDeletedAsync();
            await context.SaveChangesAsync();

            // Act
            var customers = await customerService.GetAllCustomersAsync();

            // Assert
            Assert.IsNotNull(customers);
            Assert.IsEmpty(customers);
        }

        [Test]
        public async Task GetAllCustomersAsync_ShouldReturnDistinctCustomers()
        {
            // Act
            var customers = await customerService.GetAllCustomersAsync();

            // Assert
            Assert.IsNotNull(customers);
            Assert.AreEqual(2, customers.Distinct().Count());
        }

        [Test]
        public async Task GetCustomerByIdAsync_ShouldReturnNullForNegativeCustomerId()
        {
            // Arrange
            int negativeCustomerId = -1;

            // Act
            var customer = await customerService.GetCustomerByIdAsync(negativeCustomerId);

            // Assert
            Assert.IsNull(customer);
        }

        [Test]
        public async Task GetCustomerIdByUserId_ShouldReturnZeroForNullUserId()
        {
            // Act
            var customerId = await customerService.GetCustomerIdByUserId(null);

            // Assert
            Assert.AreEqual(0, customerId);
        }
    }
}
